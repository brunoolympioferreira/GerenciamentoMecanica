using GerenciamentoMecanica.Core.Entities;
using GerenciamentoMecanica.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GerenciamentoMecanica.Infra.Persistence.Repositories
{
    public class ServiceRepository : IServiceRepository
    {
        private readonly GerenciamentoMecanicaDbContext _dbContext;

        public ServiceRepository(GerenciamentoMecanicaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Service>> GetAllServicesAsync()
        {
            return await _dbContext.Services.ToListAsync();
        }

        public async Task<Service> GetByIdAsync(int id)
        {
            return await _dbContext.Services.SingleOrDefaultAsync(s => s.Id == id);
        }

        public async Task<Service> GetServiceByIdAsync(int id)
        {
            return await _dbContext.Services
                .Include(s => s.Client)
                .Include(s => s.Vehicle)
                .SingleOrDefaultAsync(S => S.Id == id);
        }

        public async Task AddServiceAsync(Service service)
        {
            await _dbContext.Services.AddAsync(service);
            await _dbContext.SaveChangesAsync();
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
