using GerenciamentoMecanica.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoMecanica.Core.Repositories
{
    public interface IAddressRepository
    {
        #region Queries
        Task<List<Address>> GetAllAddressAsync();
        Task<Address> GetAddressByIdAsync(int id);
        Task<Address> GetAddressByClientAsync(int clientId);
        Task<Address> GetByIdAsync(int id);
        #endregion

        #region Commands
        Task AddAddressAsync(Address address);
        Task DeleteAddressAsync(int id);
        Task SaveChangesAsync();
        #endregion
    }
}
