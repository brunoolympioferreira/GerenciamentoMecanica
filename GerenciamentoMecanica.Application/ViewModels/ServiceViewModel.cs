using GerenciamentoMecanica.Core.Entities;
using GerenciamentoMecanica.Core.Enums;

namespace GerenciamentoMecanica.Application.ViewModels
{
    public class ServiceViewModel
    {
        public ServiceViewModel(int id, string serviceDescription, ServiceStatusEnum serviceStatus, int idClient, int idVehicle)
        {
            Id = id;
            ServiceDescription = serviceDescription;
            ServiceStatus = serviceStatus;
            IdClient = idClient;
            IdVehicle = idVehicle;
        }

        public int Id { get; set; }
        public string ServiceDescription { get; private set; }
        public ServiceStatusEnum ServiceStatus { get; private set; }
        public int IdClient { get; private set; }
        public int IdVehicle { get; private set; }
        public virtual Client Client { get; set; }
        public virtual Vehicle Vehicle { get; set; }
    }
}
