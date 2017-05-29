using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Add classes
using VehicleRental.Classes;

namespace VehicleRental
{
    public partial class Main : Form
    {
        Vehicle[] Vehicles = new Vehicle[3]; //Object array for vehicles

        public Main()
        {
            InitializeComponent();
            InitializeVehicles();
            cbVehicles.SelectedIndex = 0;
            rtbReport.Text = Vehicles[cbVehicles.SelectedIndex].PrintToScreen();
        }
        public void InitializeVehicles()
        {
            Vehicle VehicleTemp1 = new Vehicle();
            Vehicle VehicleTemp2 = new Vehicle();
            Vehicle VehicleTemp3 = new Vehicle();

            // Initialize values for Vehicle 0
            VehicleTemp1.Manufacturer = "Audi";
            VehicleTemp1.Model = "A6";
            VehicleTemp1.Make = "2003";
            VehicleTemp1.RegNo = "1 ABC 221";
            VehicleTemp1.TotalKMT = 0;
            VehicleTemp1.Serv = 0;
            VehicleTemp1.Fuel_econ = 0;
            VehicleTemp1.ServREQ = false;

            Vehicles[0] = VehicleTemp1; // add to the array

            // Initialize values for Vehicle 1
            VehicleTemp2.Manufacturer = "Ford";
            VehicleTemp2.Model = "T812";
            VehicleTemp2.Make = "2014";
            VehicleTemp2.RegNo = "1 ABD 760";
            VehicleTemp2.TotalKMT = 0;
            VehicleTemp2.Serv = 0;
            VehicleTemp2.Fuel_econ = 0;
            VehicleTemp2.ServREQ = false;

            Vehicles[1] = VehicleTemp2; // add to the array

            // Initialize vaues for Vehicle 2
            VehicleTemp3.Manufacturer = "Jaguar";
            VehicleTemp3.Model = "X200";
            VehicleTemp3.Make = "2003";
            VehicleTemp3.RegNo = "1 ABG 432";
            VehicleTemp3.TotalKMT = 0;
            VehicleTemp3.Serv = 0;
            VehicleTemp3.Fuel_econ = 0;
            VehicleTemp3.ServREQ = false;

            Vehicles[2] = VehicleTemp3; // add to the array
        }

        private void btnAddJourney_Click(object sender, EventArgs e)
        {
            if(txtJourney.Text != null)
            {
                double num;
                bool result = double.TryParse(txtJourney.Text, out num);
                if (result)
                {
                    Journey journey = new Journey(num);
                    Vehicles[cbVehicles.SelectedIndex].TotalKMT = Vehicles[cbVehicles.SelectedIndex].AddJourney(journey);
                    Vehicles[cbVehicles.SelectedIndex].CalcFuelEcon();
                    rtbReport.Text = Vehicles[cbVehicles.SelectedIndex].PrintToScreen() + "\n\nKilometres travelled has been updated.";
                }
                else
                {
                    MessageBox.Show("Please enter a number");
                }
            }
            else
            {
                Journey journey = new Journey(0);
                Vehicles[cbVehicles.SelectedIndex].TotalKMT = Vehicles[cbVehicles.SelectedIndex].AddJourney(journey);
                Vehicles[cbVehicles.SelectedIndex].CalcFuelEcon();
                rtbReport.Text = Vehicles[cbVehicles.SelectedIndex].PrintToScreen() + "\n\nKilometres travelled has been updated.";
            }                          
        }

        private void btnAddFuel_Click(object sender, EventArgs e)
        {
            if (txtFuel.Text != null)
            {
                int num;
                bool result = int.TryParse(txtFuel.Text, out num);
                if (result)
                {
                    FuelPurchase fuel = new FuelPurchase(num);
                    Vehicles[cbVehicles.SelectedIndex].TLpurchased = Vehicles[cbVehicles.SelectedIndex].AddFuel(num);
                    Vehicles[cbVehicles.SelectedIndex].CalcFuelEcon();
                    rtbReport.Text = Vehicles[cbVehicles.SelectedIndex].PrintToScreen() + "\n\nTotal litres of fuel has been updated.";
                }
                else
                {
                    MessageBox.Show("Please enter a number");
                }
            }
            else
            {
                FuelPurchase fuel = new FuelPurchase(0);
                Vehicles[cbVehicles.SelectedIndex].TLpurchased = Vehicles[cbVehicles.SelectedIndex].AddFuel(0);
                Vehicles[cbVehicles.SelectedIndex].CalcFuelEcon();
                rtbReport.Text = Vehicles[cbVehicles.SelectedIndex].PrintToScreen() + "\n\nTotal litres of fuel has been updated.";
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Vehicles[cbVehicles.SelectedIndex].CalcFuelEcon();
            rtbReport.Text = Vehicles[cbVehicles.SelectedIndex].PrintToScreen();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbVehicles_SelectedIndexChanged(object sender, EventArgs e)
        {
            rtbReport.Text = Vehicles[cbVehicles.SelectedIndex].PrintToScreen();
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            Vehicles[cbVehicles.SelectedIndex].Serv += 1;
            rtbReport.Text = Vehicles[cbVehicles.SelectedIndex].PrintToScreen() + "\n\nVehicle has been serviced.";
        }
    }
}
