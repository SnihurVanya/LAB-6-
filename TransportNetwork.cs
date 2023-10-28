using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_6
{
    internal class TransportNetwork
    {

        private List<Vehicle> vehicles = new List<Vehicle>();

        public void AddVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
        }

        public void ControlMovement()
        {
            foreach (var vehicle in vehicles)
            {
                vehicle.Move();
            }
        }

        public string CalculateOptimalRoute(Route route, Vehicle vehicle)
        {
            // Додайте розрахунки оптимального маршруту тут
            return $"Optimal route from {route.StartPoint} to {route.EndPoint} for {vehicle.GetType().Name}";
        }

        public void LoadPassengers()
        {
            // Логіка посадки пасажирів
        }

        public void UnloadPassengers()
        {
            // Логіка висадки пасажирів
        }
    }

}

