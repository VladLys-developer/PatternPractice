namespace PetternsPractice.FactoryPatternTransportApp
{
    // Concrete Creators override the factory method in order to change the
    // resulting transport's type.
    internal class SeaTransportCreator : LogisticsCreator
    {
        public override ITransport CreateTransport()
        {
            return new Ship();
        }
    }
}
