using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalVehicles
{
    //Class for calculations and other functions
    public class Services
    {
        //used to add journey kilometers to Vehicle total
        public double AddJourneyKM (double totalKMT, Journey journey)
        {
            double result = totalKMT + journey.KMtravelled;
            return result - 1;
        }
        //used to add journey fuel cost to vehicle total, tvl = TOTAL VEHICLE LITRES
        public int AddFuelPurchased (int tvl, Journey journey)
        {
            int result = tvl + journey.Lpurchased;
            return result;
        }
        //Calculates fuel economy
        public double FuelEconomy (Vehicle vehicle)
        {
            double result = (vehicle.TLpurchased * 100) / vehicle.TotalKMT;
            return result;
        }
        //Calculates average fuel cost
        public double AVGFuelCost(Journey journey)
        {
            double result = journey.KMtravelled / journey.TFcost;
            return result;
        }
        //Checks if service is required
        public bool servREQ(int TotalKMT)
        {
            if ((TotalKMT / 100) >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
