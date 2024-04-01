namespace LogisticsApp.Models
{
    internal class Truck : ITransport
    {
        public void deliver()
        {
            Console.WriteLine("Delivered by truck");
        }
    }
}
