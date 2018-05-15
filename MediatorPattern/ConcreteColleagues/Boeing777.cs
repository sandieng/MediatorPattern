using System;

namespace MediatorPattern
{
    public class Boeing777 : IAircraft
    {       
        public string Airline { get; set; }
        public int Altitude { get; set; }

        public Boeing777(string airline, int altitude)
        {
            Airline = airline;
            Altitude = altitude;
        }

        public void ReceiveMessage(IAircraft sender, string message)
        {
            Console.WriteLine($"{sender.Airline} @{sender.Altitude} => {Airline} @{Altitude}: {message}");
        }

        public void SendMessage(IMediator mediator, string message)
        {
            mediator.DispatchMessage(this, message);
        }
    }
}
