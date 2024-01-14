using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetternsPractice.FactoryPatternTransportApp
{
    // Client class demonstrates the usage of the transport factory.
    internal class Client
    {
        public void Main()
        {
            Console.WriteLine("App: Launched.");

            var landCreator = new LandTransportCreator();
            ClientCode(landCreator);

            Console.WriteLine("");

            var seaCreator = new SeaTransportCreator();
            ClientCode(seaCreator);

            Console.WriteLine("");

            var airCreator = new AirTransportCreator();
            ClientCode(airCreator);
        }

        // The client code works with an instance of a concrete creator, albeit
        // through its base interface. As long as the client keeps working with
        // the creator via the base interface, you can pass it any creator's
        // subclass.
        public void ClientCode(LogisticsCreator creator)
        {
            Console.WriteLine($"Client: I'm not aware of the creator's class, but it still works.\n{creator.PlanDelivery()}");
            Console.WriteLine(creator.InfoAboutTransport());
        }
    }
}
