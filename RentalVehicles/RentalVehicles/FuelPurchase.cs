using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalVehicles
{
    public class FuelPurchase
    {
        public FuelPurchase(double fuelEcon, double avgCost)
        {
            //fuel economy is number of litres per 100km
            fuelEcon = FuelEcon;
            avgCost = AVGcost;
        }
        // get vaules from (textbox) set them to new value
        public double FuelEcon { get; set; }
        public double AVGcost {get; set;}
    }

}
