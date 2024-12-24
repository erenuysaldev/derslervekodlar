﻿using ECommerce.Business.Abstract;
using ECommerce.Business.Configuration;
using ECommerce.Entity.Concrete;
using ECommerce.Shared.DTOs.Auth;
using ECommerce.Shared.ResponseDTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.JsonWebTokens;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using JwtRegisteredClaimNames = Microsoft.IdentityModel.JsonWebTokens.JwtRegisteredClaimNames;

namespace ECommerce.Business.Concrete
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IConfiguration _configuration;
        private readonly JwtConfig _jwtConfig;

        public AuthService(UserManager<ApplicationUser> userManager, IConfiguration configuration, JwtConfig jwtConfig)
        {
            _userManager = userManager;
            _configuration = configuration;
            _jwtConfig = jwtConfig;
        }

        public async Task<ResponseDTO<TokenDTO>> LoginAsync(LoginDTO loginDTO)
        {
            var user = await _userManager.FindByEmailAsync(loginDTO.Email);
            if (user == null)
            {
                return ResponseDTO<TokenDTO>.Fail("Kullanıcı bulunamadı!", StatusCodes.Status400BadRequest);
            }
            var isValidPassword = await _userManager.CheckPasswordAsync(user, loginDTO.Password);
            if (!isValidPassword)
            {
                return ResponseDTO<TokenDTO>.Fail("Hatalı şifre!", StatusCodes.Status400BadRequest);
            }
            var tokenDTO = await GenerateJwtToken(user);
            return ResponseDTO<TokenDTO>.Success(tokenDTO, StatusCodes.Status200OK);
        }
       

        public async Task<ResponseDTO<NoContent>> RegisterAsync(RegisterDTO registerDTO)
        {
            var existingUser = await _userManager.FindByEmailAsync(registerDTO.Email);
            if (existingUser != null)
            {
                return ResponseDTO<NoContent>.Fail("Bu mail adresi ile kayıtlı kullanıcı mevcut!", StatusCodes.Status400BadRequest);
            }
            ApplicationUser applicationUser = new()
            {
                Email = registerDTO.Email,
                FirstName = registerDTO.FirstName,
                LastName = registerDTO.LastName,
                UserName = registerDTO.Email,
                Address = registerDTO.Address,
                City = registerDTO.City,
                Gender = registerDTO.Gender,
                DateOfBirth = registerDTO.DateOfBirth,

            };
            var result = await _userManager.CreateAsync(applicationUser, registerDTO.Password);
            if (!result.Succeeded)
            {
                return ResponseDTO<NoContent>.Fail(result.Errors.Select(x => x.Description).ToList(), StatusCodes.Status500InternalServerError);
            }
            result = await _userManager.AddToRoleAsync(applicationUser, registerDTO.Role);
            if (!result.Succeeded)
            {
                return ResponseDTO<NoContent>.Fail(result.Errors.Select(x => x.Description).ToList(), StatusCodes.Status500InternalServerError);
            }
            return ResponseDTO<NoContent>.Success(StatusCodes.Status201Created);

        }
        private async Task<TokenDTO> GenerateJwtToken(ApplicationUser user)
        {
            var roles = await _userManager.GetRolesAsync(user);

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id),
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            }.Union(roles.Select(r => new Claim(ClaimTypes.Role, r)));

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtConfig.Secret));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expiry = DateTime.Now.AddMinutes(_jwtConfig.AccessTokenExpiration);

            var token = new JwtSecurityToken(
                issuer: _jwtConfig.Issuer,
                audience: _jwtConfig.Audience,
                claims: claims,
                expires: expiry,
                signingCredentials: credentials
            );

            var tokenDTO = new TokenDTO
            {
                AccesToken = new JwtSecurityTokenHandler().WriteToken(token),
                ExpirationDate = expiry
            };

            return tokenDTO;
        }
    }
}