namespace PetternsPractice.FactoryPatternTransportApp
{
    // Concrete Transport provide various implementations of the Transport
    // interface.
    internal class Plane: ITransport
    {
        public string Deliver()
        {
            return "{Deliver by air in a box}";
        }
        public string ProsAndCons()
        {
            return "Pros: Fast delivery for long distances. Cons: Expensive and limited cargo capacity.";
        }
    }
}
