using System.Collections.Generic;

namespace MediatorPattern
{
    public class AirTrafficController : IMediator
    {
        private List<IAircraft> _aircraftList = new List<IAircraft>();

        public List<IAircraft> AircraftList => _aircraftList;

        public void DispatchMessage(IAircraft sender, string message)
        {
            foreach (var aircraft in _aircraftList)
            {
                if (aircraft != sender)
                {
                    aircraft.ReceiveMessage(sender, message);
                }
            }
        }

        public void Register(IAircraft aircraft)
        {
            _aircraftList.Add(aircraft);
        }
    }
}
