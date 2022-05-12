using GerenciamentoMecanica.Core.Entities;
using GerenciamentoMecanica.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GerenciamentoMecanica.Infra.Persistence.Repositories
{
    public class AddressRepository : IAddressRepository
    {
        private readonly GerenciamentoMecanicaDbContext _dbContext;

        public AddressRepository(GerenciamentoMecanicaDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<List<Address>> GetAllAddressAsync()
        {
            return await _dbContext.Addresses.ToListAsync();
        }

        public async Task<Address> GetByIdAsync(int id)
        {
            return await _dbContext.Addresses.SingleOrDefaultAsync(a => a.Id == id);
        }
        public async Task<Address> GetAddressByClientAsync(int clientId)
        {
            return await _dbContext.Addresses
                .Include(a => a.Client)
                .SingleOrDefaultAsync(a => a.Id == clientId);
        }

        public async Task<Address> GetAddressByIdEmployeeAsync(int employeeId)
        {
            return await _dbContext.Addresses
                .Include(a => a.Employee)
                .SingleOrDefaultAsync(a => a.Id == employeeId);
        }

        public async Task AddAddressAsync(Address address)
        {
            await _dbContext.Addresses.AddAsync(address);
            await _dbContext.SaveChangesAsync();
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
