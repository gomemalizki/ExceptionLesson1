using System.Text;

namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DeliveryDrone[] drones = new DeliveryDrone[3];
            {
                new DeliveryDrone("DR-001", 5);
                new DeliveryDrone("DR-002", 10);
                new DeliveryDrone("DR-003", 3);
            }
            foreach (var drone in drones)
            {
                Console.WriteLine(drone);

                try
                {
                    var takeOffResult = drone.TakeOff();
                    Console.WriteLine("TakeOff: " + takeOffResult);

                    var deliveryResult = drone.AssignDelivery(packageWeight: 4, distanceKm: 10);
                    Console.WriteLine("AssignDelivery: " + deliveryResult);

                    drone.Land();
                    Console.WriteLine("After landing: " + drone);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error for {drone.Id}: {ex.Message}");
                }

                Console.WriteLine(new string('-', 50));
            }
        }
    }
}
        
    


