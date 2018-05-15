using MediatorPattern;
using System;

namespace MediatorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mediator patterns defines an object that encapsulates how a set of objects interact between themselves.
            // Communication between objects is encapsulated in a mediator object. Objects do not communicate directly with each other, but through the mediator.
            var airbusGaruda = new AirbusA320("Garuda Indonesia", 10000);
            var airbusThai = new AirbusA320("Thai Airways", 25000);
            var boeingSingapore = new Boeing777("Singapore Airlines", 35000);

            var trafficController = new AirTrafficController();
            trafficController.Register(airbusGaruda);
            trafficController.Register(airbusThai);
            trafficController.Register(boeingSingapore);

            airbusThai.SendMessage(trafficController, "Sawasdee krab");
            airbusGaruda.SendMessage(trafficController, "Apa kabar");

            Console.WriteLine("======================================================");
            Console.WriteLine("Note: Singapore Airlines does not sending any messages");
            Console.WriteLine("======================================================");
            Console.ReadKey();
        }
    }
}
