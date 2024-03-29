﻿using JWT.Algorithms;
using JWT.Builder;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.IIS;
using Microsoft.IdentityModel.JsonWebTokens;
using OnionApi.Identity;
using OnionInfrastructure;
using System.Security.Claims;
using System.Text;
using System.Linq;
namespace OnionApi.Controllers
{
    [ApiController, Route("/api/authentication")]
    public class IdentityController : Controller
    {
        private readonly UserManager<UserEntity> _manager;
        private readonly JwtSettings _jwtSettings;
        private readonly ILogger _logger;
        public RoleManager<UserRole> rolemanager;
        public IdentityController(UserManager<UserEntity> manager, RoleManager<UserRole> roleMgr, ILogger<IdentityController> logger, IConfiguration configuration, JwtSettings
       jwtSettings)
        {
            _manager = manager;
            _logger = logger;
            _jwtSettings = jwtSettings;
            rolemanager = roleMgr;
        }

        [HttpPost("register")]
        public async void Register([FromBody] LoginUserDto user)
        {
            if (!ModelState.IsValid)
            {
                return;
            }
            UserEntity userEntity = new UserEntity();
            userEntity.UserName = user.LoginName;
            
            _manager.CreateAsync(userEntity, user.Password);
            _manager.AddToRoleAsync(userEntity, "user");
            return;
        }


        [HttpPost("login")]
        [AllowAnonymous]
        public async Task<IActionResult> Authenticate([FromBody] LoginUserDto user)
        {
          
            if (!ModelState.IsValid)
            {
                return Unauthorized();
            }
            var logged = await _manager.FindByNameAsync(user.LoginName);
            if (await _manager.CheckPasswordAsync(logged, user.Password))
            {
                return Ok(new { Token = CreateToken(logged) });
            }
            return Unauthorized();
        }
        private async void GetUserRoles(UserEntity user)
        {
            role = (List<string>)await _manager.GetRolesAsync(user).ConfigureAwait(false);          
            
            
            return;
            
        }
        private List<string> role { get; set; }
        private string CreateToken(UserEntity user)
        {
            
            GetUserRoles(user);
            
            Console.WriteLine(role);
            JwtBuilder jwtb = new JwtBuilder()
            .WithAlgorithm(new HMACSHA256Algorithm())
            .WithSecret(Encoding.UTF8.GetBytes(_jwtSettings.Secret))
            .AddClaim(JwtRegisteredClaimNames.Name, user.UserName)
            .AddClaim(JwtRegisteredClaimNames.Gender, "male")
            .AddClaim(JwtRegisteredClaimNames.Email, user.Email)
            .AddClaim(JwtRegisteredClaimNames.Exp,
           DateTimeOffset.UtcNow.AddMinutes(5).ToUnixTimeSeconds())
            .AddClaim(JwtRegisteredClaimNames.Jti, Guid.NewGuid())            
            .Audience(_jwtSettings.Audience)
            .Issuer(_jwtSettings.Issuer);
            //.Encode();

            jwtb.AddClaim(ClaimTypes.Role, role);
            

            //foreach (var item in role)
            //{
            //    Console.WriteLine(item);
            //    jwtb.AddClaim(ClaimTypes.Role, role.ToString());
            //}
            return jwtb.Encode();
            // return new JwtBuilder()
            // .WithAlgorithm(new HMACSHA256Algorithm())
            // .WithSecret(Encoding.UTF8.GetBytes(_jwtSettings.Secret))
            // .AddClaim(JwtRegisteredClaimNames.Name, user.UserName)
            // .AddClaim(JwtRegisteredClaimNames.Gender, "male")
            // .AddClaim(JwtRegisteredClaimNames.Email, user.Email)
            // .AddClaim(JwtRegisteredClaimNames.Exp,
            //DateTimeOffset.UtcNow.AddMinutes(5).ToUnixTimeSeconds())
            // .AddClaim(JwtRegisteredClaimNames.Jti, Guid.NewGuid())         
            // .AddClaim(ClaimTypes.Role, role)
            // .Audience(_jwtSettings.Audience)
            // .Issuer(_jwtSettings.Issuer)
            // .Encode();
        }
    }
}
