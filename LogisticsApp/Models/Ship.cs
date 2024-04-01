namespace LogisticsApp.Models
{
    internal class Ship : ITransport
    {
        public void deliver()
        {
            Console.WriteLine("Delivered by ship");
        }
    }
}
