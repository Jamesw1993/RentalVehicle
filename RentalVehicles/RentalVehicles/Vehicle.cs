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
        public Vehicle(string manufacturer, string model,string make, string regno, int TKMT, int tfCost, int serv ,bool servREQ)
        {
            manufacturer = Manufacturer;
            model = Model;
            make = Make;
            regno = RegNo;
            TKMT = TotalKMT;
            tfCost = TFcost;
            serv = Serv;
            servREQ = ServREQ; 
        }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        public string RegNo { get; set; }
        public int TotalKMT { get; set; }
        public int TFcost { get; set; }
        public int Serv { get; set; }
        public bool ServREQ { get; set; }
    }
}
