namespace SOLID._4___D.Problem
{
    public class DataDogService
    {
        public void LogEvent(string message);
    }
    public class  OrderService
    {
        //aqui esta el problema.. si despues  necesito utilizar otro servicio
        // y no DataDogSevice tengo que modificar esta clase.
        public readonly DataDogService _dataDogService;
        public OrderService(DataDogService dataDogService)
        {
            _dataDogService = dataDogService;
        }

        public void GenerateOrder(Order order)
        {
            //todo

            //Send Notification to datalog
            _dataDogService.LogEvent("The Order was successsfully created");
        }


    }

    public class Order { }
}