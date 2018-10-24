using System.Threading.Tasks;
using Store.API.Models;

namespace Store.API.Repositories.Auth
{
    public interface IAuthRepository
    {
         Task<Employee> EmployeeLogin(string email,string password);

         Task<bool> IsAdminExist(string userName);

         Task<Employee> RegisterEmployee(Employee emp,string password);
    }
}