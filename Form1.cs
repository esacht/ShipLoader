using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShipLoader
{
    public partial class Form1 : Form
    {
        Ship ship = new Ship();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ship = new Ship();
            track_cars.Value = 0;
            track_trucks.Value = 0;
            track_motorCycles.Value = 0;
            track_trainCars.Value = 0;
            updateUI();
        }

        private void updateUI()
        {
            //set all of the controls to match the ship properties
            progressBar1.Maximum = ship.Capacity;

            if (ship.getShipLoad() <= ship.Capacity)
                progressBar1.Value = ship.getShipLoad();

            label_shipLabel.Text = ship.ToString();

            //motorcycles
            label_cycleCount.Text = ship.CycleCount.ToString();

            //cars
            label_carCount.Text = ship.CarCount.ToString();

            //truck
            label_truckCount.Text = ship.TruckCount.ToString();

            //trains
            label_trainCount.Text = ship.TrainCarCount.ToString();

            //progress bar colours
            if (ship.overUnder() == 0)
            {
                progressBar1.ForeColor = Color.Green;
                string message = "Congratulations you loaded the ship correctly!";
                string caption = "Winner! Click New Ship for a new game";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
            }

            if (ship.overUnder() > 0)
            {
                progressBar1.ForeColor = Color.Yellow;
            }

            if (ship.overUnder() < 0)
            {
                progressBar1.ForeColor = Color.Red;
            }
        }

        private void track_motorCycles_Scroll(object sender, EventArgs e)
        {
            ship.CycleCount = track_motorCycles.Value;
            updateUI();
        }

        private void track_cars_Scroll(object sender, EventArgs e)
        {
            ship.CarCount = track_cars.Value;
            updateUI();
        }

        private void track_trucks_Scroll(object sender, EventArgs e)
        {
            ship.TruckCount = track_trucks.Value;
            updateUI();
        }

        private void track_trainCars_Scroll(object sender, EventArgs e)
        {
            ship.TrainCarCount = track_trainCars.Value;
            updateUI();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.Style = ProgressBarStyle.Continuous;
            updateUI();
        }
    }
}
