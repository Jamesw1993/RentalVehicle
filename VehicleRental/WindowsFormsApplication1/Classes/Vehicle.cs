using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace namespace VehicleRental.Classes
{
    public class Vehicle
    {
        public Vehicle() { }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string Make { get; set; } //Year
        public string RegNo { get; set; } //registration number
        public double TotalKMT { get; set; } //Total kilometres travelled
        public int TLpurchased { get; set; } //Total litres purchased
        public int Serv { get; set; } //Services had
        public bool ServREQ { get; set; } //whether or not a service is required
        public double Fuel_econ { get; set; } //per 100km
        public void PrintToScreen() //Format for vehicle report
        {
            string output =
                "\n\nManufacturer: " + Manufacturer +
                "\nModel: " + Model +
                "\nProduction Date: " + Make +
                "\nRegistration: " + RegNo +
                "\nTotal Km Travelled: " + TotalKMT +
                "\nTotal Services: " + Serv +
                "\nFuel Economy: " + Fuel_econ +
                "\nService Required: " + ServREQ;
        }
    }
}
