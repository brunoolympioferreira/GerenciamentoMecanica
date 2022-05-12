using GerenciamentoMecanica.Core.Entities;
using GerenciamentoMecanica.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GerenciamentoMecanica.Infra.Persistence.Repositories
{
    public class VehicleRepository : IVehicleRepository
    {
        private readonly GerenciamentoMecanicaDbContext _dbContext;

        public VehicleRepository(GerenciamentoMecanicaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Vehicle>> GetAllVehiclesAsync()
        {
            return await _dbContext.Vehicles.ToListAsync();
        }

        public async Task<Vehicle> GetByIdAsync(int id)
        {
            return await _dbContext.Vehicles.SingleOrDefaultAsync(v => v.Id == id);
        }

        public async Task<Vehicle> GetVehicleByIdAsync(int id)
        {
            return await _dbContext.Vehicles
                .Include(v => v.Client)
                .SingleOrDefaultAsync(v => v.Id == id);
        }

        public async Task AddVehicleAsync(Vehicle vehicle)
        {
            await _dbContext.Vehicles.AddAsync(vehicle);
            await _dbContext.SaveChangesAsync();
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
