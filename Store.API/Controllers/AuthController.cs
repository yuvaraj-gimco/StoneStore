using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Store.API.DTOs;
using Store.API.Models;
using Store.API.Repositories.Auth;

namespace Store.API.Controllers
{
    [Route("api/[Controller]")]
    public class AuthController:Controller
    {
        private readonly IAuthRepository _repo;
        private readonly IConfiguration _config;

        public AuthController(IAuthRepository repo,IConfiguration config)
        {
            _repo = repo;
            _config = config;
        }

        [HttpPost("RegisterEmployee")]
        public async Task<IActionResult> RegisterEmployee([FromBody]EmployeeRegisterDto model){

           if(await _repo.IsAdminExist(model.UserName.ToLower()))
            ModelState.AddModelError("UserName","user already exists");

            if(!ModelState.IsValid)
            return BadRequest(ModelState);

            var emp=new Employee(){
                FirstName="Yuvaraj",
                LastName="D",
                Company="Ailerin",
                Contact="9666187277",
                IsIos=true,
                Email=model.UserName,
                Role="Admin",
                CreatedAt=DateTime.UtcNow,
                UpdatedAt=DateTime.UtcNow
            };
            var result=await _repo.RegisterEmployee(emp,model.Password);
           return Ok(result);
        }

        [HttpPost("EmployeeLogin")]
        public async Task<IActionResult> EmployeeLogin([FromBody] EmployeeLoginDto model){

            var emp=await _repo.EmployeeLogin(model.UserName.ToLower(),model.Password);

            if(emp==null)
            return Unauthorized();

            var tokenHandler=new JwtSecurityTokenHandler();
            var key=Encoding.ASCII.GetBytes(_config.GetSection("AppSettings:Token").Value);
            var tokenDescriptor=new SecurityTokenDescriptor(){
                
                Subject=new ClaimsIdentity(new Claim[]{
                    new Claim(ClaimTypes.NameIdentifier,emp.Id.ToString()),
                    new Claim(ClaimTypes.Name,emp.FirstName)
                }),
                Expires=DateTime.Now.AddDays(1),
                SigningCredentials=new SigningCredentials(new SymmetricSecurityKey(key),SecurityAlgorithms.HmacSha512Signature)

            };
            var token=tokenHandler.CreateToken(tokenDescriptor);
            var tokenString =tokenHandler.WriteToken(token);

           return Ok(new { tokenString});
        }
        
    }
}