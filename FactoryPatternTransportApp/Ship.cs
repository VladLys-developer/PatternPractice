namespace PetternsPractice.FactoryPatternTransportApp
{
    // Concrete Transport provide various implementations of the Transport
    // interface.
    internal class Ship: ITransport
    {
        public string Deliver()
        {
            return "{Deliver by sea in a container}";
        }
        public string ProsAndCons()
        {
            return "Pros: High cargo capacity for large shipments. Cons: Slow delivery compared to other modes.";
        }
    }
}
