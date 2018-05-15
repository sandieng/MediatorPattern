using System.Collections.Generic;

namespace MediatorPattern
{
    public interface IMediator
    {
        List<IAircraft> AircraftList { get; }
        void DispatchMessage(IAircraft sender, string message);
        void Register(IAircraft aircraft);
    }
}