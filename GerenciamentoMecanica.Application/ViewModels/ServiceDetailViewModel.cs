using GerenciamentoMecanica.Core.Entities;
using GerenciamentoMecanica.Core.Enums;
using System;

namespace GerenciamentoMecanica.Application.ViewModels
{
    public class ServiceDetailViewModel
    {
        public ServiceDetailViewModel(int id, string serviceDescription, DateTime inputData, DateTime? updatedData, DateTime? outputData, decimal? totalCost, ServiceStatusEnum serviceStatus, int idClient, int idVehicle)
        {
            Id = id;
            ServiceDescription = serviceDescription;
            InputData = inputData;
            UpdatedData = updatedData;
            OutputData = outputData;
            TotalCost = totalCost;
            ServiceStatus = serviceStatus;
            IdClient = idClient;
            IdVehicle = idVehicle;
        }

        public int Id { get; set; }
        public string ServiceDescription { get; private set; }
        public DateTime InputData { get; private set; }
        public DateTime? UpdatedData { get; private set; }
        public DateTime? OutputData { get; private set; }
        public decimal? TotalCost { get; private set; }
        public ServiceStatusEnum ServiceStatus { get; private set; }
        public int IdClient { get; private set; }
        public int IdVehicle { get; private set; }

        public virtual Client Client { get; set; }
        public virtual Vehicle Vehicle { get; set; }
    }
}
