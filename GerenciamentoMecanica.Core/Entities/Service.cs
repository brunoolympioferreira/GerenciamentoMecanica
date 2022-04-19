using GerenciamentoMecanica.Core.Enums;
using System;

namespace GerenciamentoMecanica.Core.Entities
{
    public class Service : BaseEntity
    {
        public Service(string serviceDescription, DateTime? outputData, decimal? totalCost, int idClient, int idVehicle)
        {
            ServiceDescription = serviceDescription;
            OutputData = outputData;
            TotalCost = totalCost;
            IdClient = idClient;
            IdVehicle = idVehicle;

            InputData = DateTime.Now;
            ServiceStatus = ServiceStatusEnum.InProgress;

        }

        public string ServiceDescription { get; private set; }
        public DateTime InputData { get; private set; }
        public DateTime? OutputData { get; private set; }
        public decimal? TotalCost { get; private set; }
        public ServiceStatusEnum ServiceStatus { get; private set; }
        public int IdClient { get; private set; }
        public int IdVehicle { get; private set; }
        public Client Client { get; set; }
        public Vehicle Vehicle { get; set; }

        public void Cancel()
        {
            if (ServiceStatus == ServiceStatusEnum.InProgress)
            {
                ServiceStatus = ServiceStatusEnum.Canceled;
            }
        }

        public void Finish()
        {
            if (ServiceStatus == ServiceStatusEnum.InProgress)
            {
                ServiceStatus = ServiceStatusEnum.Finished;
                OutputData = DateTime.Now;
            }
        }

        //public void Update(string serviceDescription, decimal totalCost)
        //{
        //    ServiceDescription = serviceDescription;
        //    TotalCost = totalCost;
        //}
    }
}
