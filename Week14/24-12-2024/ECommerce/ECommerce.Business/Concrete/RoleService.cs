using ECommerce.Business.Abstract;
using ECommerce.Entity.Concrete;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Business.Concrete
{
    public class RoleService:IRoleService
    {   private readonly RoleManager<ApplicationRole> _roleManager;

        public RoleService(RoleManager<ApplicationRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public async Task SeedRolesAsync()
        {
            if(!await _roleManager.RoleExistsAsync("NormalUser"))
            {
                var userRole = new ApplicationRole {Name = "NormalUser", Description = "Sistemi kullanacak genel kullanıcılar için tanımlanan rol",NormalizedName="NORMALUSER" };
                await _roleManager.CreateAsync(userRole);
            };
            if (!await _roleManager.RoleExistsAsync("AdminUser"))
            {
                var userRole = new ApplicationRole { Name = "AdminUser", Description = "Admin rolü", NormalizedName = "ADMINUSER" };
                await _roleManager.CreateAsync(userRole);
            };
        }
        }
    }

