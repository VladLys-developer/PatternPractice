using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetternsPractice.FactoryPatternTransportApp
{
    // The LogisticsCreator class declares the factory method that is supposed to return
    // an object of a Product class. The LogisticsCreator's subclasses usually provide
    // the implementation of this method.
    internal abstract class LogisticsCreator
    {
        public abstract ITransport CreateTransport();

        private ITransport transport;

        internal LogisticsCreator() {
            transport = CreateTransport();
        }
        public string PlanDelivery()
        {
            var result = "LogisticsCreator: The same creator's code has just worked with " + this.transport.Deliver();
            return result;
        }
        public string InfoAboutTransport()
        {
            var info = $"Useful information about the transport you choosed: \n{this.transport.ProsAndCons()}";
            return info;
        }
    }
}
