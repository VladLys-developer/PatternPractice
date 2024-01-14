namespace PetternsPractice.FactoryPatternTransportApp
{
    // Concrete Transport provide various implementations of the Transport
    // interface.
    internal class Train: ITransport
    {
        public string Deliver()
        {
            return "{Deliver by rails in a railway carriage}";
        }
        public string ProsAndCons()
        {
            return "Pros: Efficient for heavy cargo over land. Cons: Limited coverage compared to other modes.";
        }
    }
}
