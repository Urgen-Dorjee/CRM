using CRM.Core.Domain.Bus;
using CRM.Core.Domain.Commands;
using CRM.Core.Domain.Events;
using MediatR;
using System.Threading.Tasks;

namespace CRM.Core.Domain.Services
{
    public class InMemory : IMediatorHandler
    {
        private readonly IMediator _busService;

        public InMemory(IMediator busService)
        {
            _busService = busService;
        }
        public Task RaiseEvent<T>(T message) where T : Event
        {
            return _busService.Publish(message);
        }

        public Task SendCommand<T>(T command) where T : Command
        {
            return _busService.Send(command);
        }
    }
}
