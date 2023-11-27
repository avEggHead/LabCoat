namespace LabCoat.Experiments
{
    public class Vehicle 
    {
        public Vehicle CreateVehicle()
        {
            Vehicle myVehicle = new Vehicle();
            System.Console.WriteLine("Inside Vehicle.CreateVehicle, a vehicle object is created.");
            return myVehicle;
        }
    }

    public class Bus : Vehicle
    {
        public Bus CreateBus()
        {
            Bus myBus = new Bus();
            System.Console.WriteLine("Inside Bus.CreateBUs, a bus object is created");
            return myBus;
        }
    }


    internal class CovarianceDelegate : IExperiment
    {
        public delegate Vehicle VehicleDelegate();
        public void Experiment()
        {
            Vehicle vehicle = new Vehicle();
            Bus bus = new Bus();
            System.Console.WriteLine("Testing Covariance with Delegates it is allow with C# 2.0 onwards");
            VehicleDelegate vehicleDelegate1 = vehicle.CreateVehicle;
            vehicleDelegate1();
            VehicleDelegate vehicleDelegate2 = bus.CreateBus;
            vehicleDelegate2();
        }

        public string IdentifyExperiment()
        {
            return "CovarianceDelegate";
        }
    }
}