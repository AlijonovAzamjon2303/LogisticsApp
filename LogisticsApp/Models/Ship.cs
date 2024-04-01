namespace LogisticsApp.Models
{
    internal class Ship : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Delivered by ship");
        }
    }
}
