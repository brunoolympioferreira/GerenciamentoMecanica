using GerenciamentoMecanica.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GerenciamentoMecanica.Core.Repositories
{
    public interface IEmployeeRepository
    {
        #region Queries
        Task<List<Employee>> GetAllEmployeesAsync();
        Task<Employee> GetEmployeeById(int id);
        Task<Employee> GetById(int id);
        #endregion

        #region Commands
        Task AddEmployee(Employee employee);
        Task SaveChangesAsync();
        #endregion
    }
}
