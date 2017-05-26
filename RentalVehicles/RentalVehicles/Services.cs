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
        public int AddJourneyKM (int totalKMT, Journey journey)
        {
            int result = totalKMT + journey.KMtravelled;
            return result;
        }
        //used to add journey fuel cost to vehicle total
        public int AddFuelPurchased (int TFcost, Journey journey)
        {
            int result = TFcost + journey.FuelCost;
            return result;
        }
        //Calculates fuel economy
        public double FuelEconomy (Vehicle vehicle)
        {
            double result = 100 / AVGFuelCost(vehicle);
            return result;
        }
        //Calculates average fuel cost
        public int AVGFuelCost(Vehicle vehicle)
        {
            int result = vehicle.TotalKMT / vehicle.TFcost;
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
