using GerenciamentoMecanica.Core.Entities;
using GerenciamentoMecanica.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GerenciamentoMecanica.Infra.Persistence.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly GerenciamentoMecanicaDbContext _dbContext;

        public EmployeeRepository(GerenciamentoMecanicaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Employee>> GetAllEmployeesAsync()
        {
            return await _dbContext.Employees.ToListAsync();
        }

        public async Task<Employee> GetById(int id)
        {
            return await _dbContext.Employees.SingleOrDefaultAsync(e => e.Id == id);
        }

        public async Task<Employee> GetEmployeeById(int id)
        {
            return await _dbContext.Employees
                .Include(e => e.Address)
                .SingleOrDefaultAsync(e => e.Id == id);
        }

        public async Task AddEmployee(Employee employee)
        {
            await _dbContext.Employees.AddAsync(employee);
            await _dbContext.SaveChangesAsync();
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
