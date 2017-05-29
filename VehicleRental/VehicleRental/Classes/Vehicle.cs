using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRental.Classes
{
    public class Vehicle
    {
        public Vehicle() { }
        public Vehicle( string manufacturer, string model, string make, string regno, double totalkmt, double tlpurchased, int serv, bool servreq, double fuelecon)
        {
            manufacturer = Manufacturer;
            model = Model;
            make = Make;
            regno = RegNo;
            TotalKMT = totalkmt;
            TLpurchased = TLpurchased;
            Serv = serv;
            ServREQ = servreq;
            Fuel_econ = fuelecon;
        }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string Make { get; set; } //Year
        public string RegNo { get; set; } //registration number
        public double TotalKMT { get; set; } //Total kilometres travelled
        public int TLpurchased { get; set; } //Total litres purchased
        public int Serv { get; set; } //Services had
        public bool ServREQ { get; set; } //whether or not a service is required
        public double Fuel_econ { get; set; } //per 100km
        public double AddJourney(Journey journey)
        {
            double result = journey.KMT + TotalKMT;
            return result;
        }
        public int AddFuel(int ltrs)
        {
            int fuel = ltrs;
            return fuel;
        }
        public double CalcFuelEcon()
        {
            Fuel_econ = (TLpurchased * 100) / TotalKMT;
            return Fuel_econ;
        }
        public string PrintToScreen() //Format for vehicle report
        {
            string output =
                "Manufacturer: " + Manufacturer +
                "\nModel: " + Model +
                "\nProduction Date: " + Make +
                "\nRegistration: " + RegNo +
                "\nTotal Km Travelled: " + TotalKMT +
                "\nTotal Litres of Fuel:" + TLpurchased +
                "\nTotal Services: " + Serv +
                "\nFuel Economy: " + Fuel_econ + "/100km" +
                "\nService Required: " + ServREQ;
            return output;
        }
    }
}
