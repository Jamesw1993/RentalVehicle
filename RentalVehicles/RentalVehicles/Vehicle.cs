using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalVehicles
{
    public class Vehicle
    {
        public Vehicle() { }
        public Vehicle(string manufacturer, string model,string make, string regno, double TKMT, int tlpurchased, int serv ,bool servREQ)
        {
            manufacturer = Manufacturer;
            model = Model;
            make = Make;
            regno = RegNo;
            TKMT = TotalKMT;
            tlpurchased = TLpurchased;
            serv = Serv;
            servREQ = ServREQ; 
        }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        public string RegNo { get; set; }
        public double TotalKMT { get; set; }
        public int TLpurchased { get; set; }
        public int Serv { get; set; }
        public bool ServREQ { get; set; }
    }
}
