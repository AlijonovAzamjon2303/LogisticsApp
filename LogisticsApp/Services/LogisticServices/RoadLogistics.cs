using LogisticsApp.Models;

namespace LogisticsApp.Services.LogisticServices
{
    internal class RoadLogistics : ILogistics
    {
        ITransport transport; 
        ITransport CreateTransport()
        {
            return new Truck();
        }
        public void Deliver()
        {
            this.transport.Deliver();
        }

        public void PlanDelivery()
        {
            this.transport = this.CreateTransport();
        }
    }
}
