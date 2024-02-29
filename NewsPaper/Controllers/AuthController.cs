﻿using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using ManagingANewspaper.models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace ManagingANewspaper.Controllers
{
    
        [Route("api/[controller]")]
        [ApiController]
        public class AuthController : ControllerBase
        {
            private readonly IConfiguration _configuration;

            public AuthController(IConfiguration configuration)
            {
                _configuration = configuration;
            }

            [HttpPost]
            public IActionResult Login([FromBody] LoginModel loginModel)
            {
                if (loginModel.UserName == "Tami&Rivki" && loginModel.Password == "123456")
                {
                    var claims = new List<Claim>()
            {
                new Claim("Name",loginModel.UserName),
                new Claim("Password", loginModel.Password)
            };

                    var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration.GetValue<string>("JWT:Key")));
                    var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
                    var tokeOptions = new JwtSecurityToken(
                        issuer: _configuration.GetValue<string>("JWT:Issuer"),
                        audience: _configuration.GetValue<string>("JWT:Audience"),
                        claims: claims,
                        expires: DateTime.Now.AddMinutes(6),
                        signingCredentials: signinCredentials
                    );
                    var tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);
                    return Ok(new { Token = tokenString });
                }
                return Unauthorized();
            }
        }

    
}
