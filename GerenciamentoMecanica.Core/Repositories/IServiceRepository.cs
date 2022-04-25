using GerenciamentoMecanica.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GerenciamentoMecanica.Core.Repositories
{
    public interface IServiceRepository
    {
        #region Queries
        Task<List<Service>> GetAllServicesAsync();
        Task<Service> GetServiceByIdAsync(int id);
        Task<Service> GetByIdAsync(int id);
        #endregion

        #region Commands
        Task AddServiceAsync(Service service);
        Task SaveChangesAsync();
        #endregion
    }
}
