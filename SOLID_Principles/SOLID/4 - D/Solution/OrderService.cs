namespace SOLID._4___D.Solution
{
    internal class OrderService
    {
        public readonly IEventNotificationService _eventNotificationService;

        public OrderService(IEventNotificationService eventNotificationService)
        {
            _eventNotificationService = eventNotificationService;
        }

        public void GenerateOrder(Order order)
        {
            //todo codigo

            //send notification to datalog
            _eventNotificationService.LogEvent("The order was successfully created");
        }
    }

    public class Order
    {

    }
}