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
        Task<Employee> AddEmployee(Employee employee);
        Task<Employee> AdmissionAsync(Employee employee);
        Task<Employee> ResignationAsync(Employee employee);
        Task<Employee> VacationAsync(Employee employee);
        Task<Employee> EmployeeAfastamentAsync(Employee employee);
        Task<Employee> UpdateEmployeeAsync(Employee employee);
        Task SaveChangesAsync();
        #endregion
    }
}
