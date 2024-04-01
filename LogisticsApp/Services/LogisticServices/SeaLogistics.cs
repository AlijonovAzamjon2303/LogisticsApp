using LogisticsApp.Models;

namespace LogisticsApp.Services.LogisticServices
{
    internal class SeaLogistics : ILogistics
    {
        ITransport transport;
        ITransport CreateTransport()
        {
            return new Ship();
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
