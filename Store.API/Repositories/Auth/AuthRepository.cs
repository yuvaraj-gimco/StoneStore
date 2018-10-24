using System.Threading.Tasks;
using Store.API.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Store.API.Repositories.Auth
{
    public class AuthRepository : IAuthRepository
    {
        public StoreDBContext Db { get; }
        public AuthRepository(StoreDBContext db)
        {
            Db = db;

        }
        public async Task<Employee> EmployeeLogin(string email, string password)
        {
            var emp=await Db.Employees.FirstOrDefaultAsync(c =>c.Email==email);

            if(emp==null)
            return null;
            if(!VerifyPasswordHash(password,emp.PasswordHash,emp.PasswordSalt))
            return null;

            //auth successfull

            return emp;
        }

        private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using(var hmac=new System.Security.Cryptography.HMACSHA512(passwordSalt)){
                var computedHash= hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                for(int i=0;i <computedHash.Length;i++){
                    if(computedHash[i] != passwordHash[i]) return false;
                }
                return true;
            }
        }

        public async Task<Employee> RegisterEmployee(Employee emp,string password){
            
            byte[] passwordHash,passwordSalt;
            createPasswordHash(password,out passwordHash,out passwordSalt);
            emp.PasswordHash=passwordHash;
            emp.PasswordSalt=passwordSalt;

            await Db.Employees.AddAsync(emp);
            await Db.SaveChangesAsync();

            return emp;
        }

        private void createPasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using(var hmac=new System.Security.Cryptography.HMACSHA512()){
                passwordSalt=hmac.Key;
                passwordHash=hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }

        public async Task<bool> IsAdminExist(string userName)
        {
           if(await Db.Employees.AnyAsync(c =>c.Email==userName))
           return true;


           return false;
        }
    }
}