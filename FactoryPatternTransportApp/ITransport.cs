using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetternsPractice.FactoryPatternTransportApp
{
    // ITransport interface defines the common method for all transport types.
    internal interface ITransport
    {
        string Deliver();
        string ProsAndCons();
    }
}
