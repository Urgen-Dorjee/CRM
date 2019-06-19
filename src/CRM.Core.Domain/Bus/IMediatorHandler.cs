using CRM.Core.Domain.Commands;
using CRM.Core.Domain.Events;
using System.Threading.Tasks;

namespace CRM.Core.Domain.Bus
{
    public interface IMediatorHandler
    {
        Task SendCommand<T>(T command) where T : CoreCommand;
        Task RaiseEvent<T>(T message) where T : Event;
    }
}
