﻿using ECommerce.Business.Abstract;
using ECommerce.Shared.DTOs.Auth;
using ECommerce.Shared.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : CustomControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterDTO registerDTO)
        {
            var response = await _authService.RegisterAsync(registerDTO);
            return CreateResponse(response);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDTO loginDTO)
        {
            var response = await _authService.LoginAsync(loginDTO);
            return CreateResponse(response);
        }


    }
}
