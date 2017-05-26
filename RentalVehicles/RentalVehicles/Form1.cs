using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalVehicles
{
    public partial class Form1 : Form
    {
        private Services services;
        public Form1()
        {
            InitializeComponent();
            services = new Services();
        }

        private string PrintToScreen(Vehicle vehicle, FuelPurchase fuelpurchase)
        {
            string output = " Manufacturer: " + vehicle.Manufacturer + "\n Model: " + vehicle.Model + "\n Make: " + vehicle.Make + "\n Reg. number: "
                + vehicle.RegNo + "\n Total Kilometres Travelled: " + vehicle.TotalKMT + "\n Fuel Economy: " + fuelpurchase.FuelEcon + "/100km \n Service Required: " + vehicle.ServREQ + "\n Average fuel cost: " + fuelpurchase.AVGcost;

            return output;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Ignore this button, it will be removed later.
        private void button2_Click(object sender, EventArgs e)
        {
            /*
            Vehicle vehicle = new Vehicle(txtManufacturer.Text, txtModel.Text, txtMake.Text, txtReg.Text, 0, 0);
            
            For testing the object before methods were created
            if(vehicle != null)
            {
                MessageBox.Show("Success");
            }
            */
            
            
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            Journey journey = new Journey(Int32.Parse(txtKMtravelled.Text), Int32.Parse(txtFuelCost.Text), Int32.Parse(txtFuelCost.Text))
            {
                KMtravelled = Int32.Parse(txtKMtravelled.Text),
                Lpurchased = Int32.Parse(txtFuelCost.Text),
                TFcost = Int32.Parse(txtTFcost.Text)
            };
            Vehicle vehicle = new Vehicle(txtManufacturer.Text, txtModel.Text, txtMake.Text, txtReg.Text, 0, 0, 0, false)
            {
                Manufacturer = txtManufacturer.Text,
                Model = txtModel.Text,
                Make = txtMake.Text,
                RegNo = txtReg.Text,
                TLpurchased = services.AddFuelPurchased(Int32.Parse(txtTFP.Text), journey),
                TotalKMT = services.AddJourneyKM(Int32.Parse(txtTKMT.Text), journey),
                Serv = 0,
                ServREQ = services.servREQ(Int32.Parse(txtTKMT.Text))                
            };
            txtTKMT.Text = vehicle.TotalKMT.ToString();
            txtTFP.Text = vehicle.TLpurchased.ToString();
            FuelPurchase fuelpurchase = new FuelPurchase(services.FuelEconomy(vehicle), services.AVGFuelCost(journey))
            {
                FuelEcon = services.FuelEconomy(vehicle),
                AVGcost = services.AVGFuelCost(journey)
            };
            MessageBox.Show(PrintToScreen(vehicle, fuelpurchase));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
