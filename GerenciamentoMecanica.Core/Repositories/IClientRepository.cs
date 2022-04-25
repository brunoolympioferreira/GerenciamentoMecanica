using GerenciamentoMecanica.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GerenciamentoMecanica.Core.Repositories
{
    public interface IClientRepository
    {
        #region Queries

        Task<List<Client>> GetAllClientsAsync();
        Task<Client> GetClientsByIdAsync(int id);
        Task<Client> GetByIdAsync(int id);

        #endregion

        #region Commands

        Task AddClientAsync(Client client);
        Task SaveChangesAsync();

        #endregion
    }
}
