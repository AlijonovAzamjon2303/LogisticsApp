using LogisticsApp.Models;

namespace LogisticsApp.Services.LogisticServices
{
    internal interface ILogistics
    {
        void PlanDelivery();
        void Deliver();
    }
}
