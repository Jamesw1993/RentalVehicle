using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalVehicles
{
    public class Journey
    {
        public Journey(double kmTravelled, int lPurchased, double tfCost)
        {
            kmTravelled = KMtravelled;
            lPurchased = Lpurchased;
            tfCost = TFcost;
        }
        public double KMtravelled { get; set; }
        public int Lpurchased { get; set; }
        public double TFcost { get; set; }
    }
}
