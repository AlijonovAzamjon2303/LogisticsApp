namespace LogisticsApp.Models
{
    internal class Truck : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Delivered by truck");
        }
    }
}
