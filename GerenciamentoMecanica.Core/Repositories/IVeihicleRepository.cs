using GerenciamentoMecanica.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GerenciamentoMecanica.Core.Repositories
{
    public interface IVeihicleRepository
    {
        #region Queries
        Task<List<Vehicle>> GetAllVehiclesAsync();
        Task<Vehicle> GetVehicleByIdAsync(int id);
        Task<Vehicle> GetVehicleByClient(int clientId);
        Task<Vehicle> GetByIdAsync(int id);
        #endregion

        #region Commands
        Task AddVehicleAsync(Vehicle vehicle);
        Task DeleteVehicleAsync(int id);
        Task SaveChangesAsync();
        #endregion
    }
}
