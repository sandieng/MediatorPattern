namespace MediatorPattern
{
    public interface IAircraft
    {
        void SendMessage(IMediator mediator, string message);
        void ReceiveMessage(IAircraft sender, string message);
        string Airline { get; set; }
        int Altitude { get; set; }
    }
}
