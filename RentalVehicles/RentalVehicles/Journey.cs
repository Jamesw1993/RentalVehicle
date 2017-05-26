using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalVehicles
{
    public class Journey
    {
        public Journey(double kmTravelled, double fuelCost)
        {
            kmTravelled = KMtravelled;
            fuelCost = FuelCost;
        }
        public int KMtravelled { get; set; }
        public int FuelCost { get; set; }
    }
}
