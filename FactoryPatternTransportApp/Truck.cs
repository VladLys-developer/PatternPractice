namespace PetternsPractice.FactoryPatternTransportApp
{
    // Concrete Transport provide various implementations of the Transport
    // interface.
    internal class Truck: ITransport
    {
        public string Deliver()
        {
            return "{Deliver by land in a box}";
        }
        public string ProsAndCons()
        {
            return "Pros: Flexible for short to medium distances. Cons: Limited capacity for large shipments.";
        }
    }
}
