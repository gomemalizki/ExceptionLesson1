using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    internal class DeliveryDrone
    {
        public string Id { get; }
        public double MaxWeightKg { get; }
        private double batteryPercentage;

        public double BatteryPercentage {
            get => batteryPercentage;
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentOutOfRangeException(nameof(BatteryPercentage), "Battery must be between 0 and 100");
                    batteryPercentage = value;
                }
            }
        }
        public int CurrentAltitude { get; private set; }
        private string status;
        public string Status
        {
            get => status;
            set
            {
                if (value != "Grounded" && value != "InFlight" && value != "ReturningHome")
                    throw new ArgumentException("Status must be one of: Grounded, InFlight, ReturningHome.");
                status = value;
            }
        }

        public DeliveryDrone(string id, double maxWeightCapacity)
        {
            Id = id;
            MaxWeightKg = maxWeightCapacity;
            BatteryPercentage = 100;
            Status = "Grounded";
            CurrentAltitude = 0;
            if (string.IsNullOrWhiteSpace(id))
                throw new ArgumentNullException(nameof(id), "Id cannot be null or empty.");

            if (maxWeightCapacity <= 0)
                throw new ArgumentOutOfRangeException(nameof(maxWeightCapacity), "Max weight capacity must be greater than zero.");

        }

        public DeliveryResult TakeOff()
        {
            if (BatteryPercentage < 30)
                return DeliveryResult.Failure ("Battery too low to take off.);
            
            if (Status != "Grounded")
                throw new InvalidOperationException("Drone must be Grounded to take off.");
            CurrentAltitude = 50;
            Status = "InFlight";
            return DeliveryResult.Success();

        }
        public DeliveryResult AssignDelivery(double packageWeight, int distanceKm)
        {
            if(packageWeight> MaxWeightKg)
            {
                return DeliveryResult.Failure("Package weight exceeds drone capacity.");
            }
            double estimatedBatteryUse = distanceKm * 5; 
            if (estimatedBatteryUse > BatteryPercentage)
                return DeliveryResult.Failure("Not enough battery for delivery.");
            if(Status!= "InFlight")
            {
                throw new InvalidOperationException("Drone must be InFlight to assign a delivery.");
            }
            BatteryPercentage -= estimatedBatteryUse;
            Status = "ReturningHome";
            return DeliveryResult.Success();
        }

        public void Land()
        {
            if(Status!="Coming Home")
            {
                throw new InvalidOperationException("Drone must be ReturningHome to land.");
            }
            CurrentAltitude = 0;
            Status = "Grounded";
        }





    }
}
