using GerenciamentoMecanica.Application.ViewModels;
using GerenciamentoMecanica.Core.Repositories;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace GerenciamentoMecanica.Application.Queries.ServiceQueries.GetServiceById
{
    public class GetServiceByIdQueryHandler : IRequestHandler<GetServiceByIdQuery, ServiceDetailViewModel>
    {
        private readonly IServiceRepository _serviceRepository;

        public GetServiceByIdQueryHandler(IServiceRepository serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }
        public async Task<ServiceDetailViewModel> Handle(GetServiceByIdQuery request, CancellationToken cancellationToken)
        {
            var service = await _serviceRepository.GetServiceByIdAsync(request.Id);

            if (service == null) return null;

            var serviceDetailsViewModel = new ServiceDetailViewModel(
                service.Id, service.ServiceDescription, service.InputData, service.UpdatedData,
                service.OutputData, service.TotalCost, service.ServiceStatus, service.IdClient, service.IdVehicle
                );

            return serviceDetailsViewModel;
        }
    }
}
