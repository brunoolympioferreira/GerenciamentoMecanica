using GerenciamentoMecanica.Core.Entities;
using GerenciamentoMecanica.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GerenciamentoMecanica.Infra.Persistence.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly GerenciamentoMecanicaDbContext _dbContext;

        public ClientRepository(GerenciamentoMecanicaDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Client>> GetAllClientsAsync()
        {
            return await _dbContext.Clients.ToListAsync();
        }

        public async Task<Client> GetByIdAsync(int id)
        {
            return await _dbContext.Clients.SingleOrDefaultAsync(c => c.Id == id);
        }

        public async Task<Client> GetClientsByIdAsync(int id)
        {
            return await _dbContext.Clients
                .Include(c => c.Address)
                .SingleOrDefaultAsync(c => c.Id == id);
        }

        public async Task AddClientAsync(Client client)
        {
            await _dbContext.Clients.AddAsync(client);
            await _dbContext.SaveChangesAsync();
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
