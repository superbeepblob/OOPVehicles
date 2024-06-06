using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OOPVehicles
{
    public partial class MainWindow : Window
    {
        private VehicleShop vehicleShop;

        public MainWindow()
        {
            InitializeComponent();
            vehicleShop = new VehicleShop();
        }

        private void btnAddVehicle_Click(object sender, RoutedEventArgs e)
        {
            string model = tbModel.Text;
            int year = int.Parse(tbYear.Text);
            string registrationNumber = tbRegistrationNumber.Text;
            string specific = tbSpecific.Text;
            string vehicleType = (cbVehicleType.SelectedItem as ComboBoxItem)?.Content.ToString();

            Vehicle vehicle = null;

            if (vehicleType == "Car")
            {
                vehicle = new Car( model, year, registrationNumber, int.Parse(specific));
            }
            else if (vehicleType == "Truck")
            {
                vehicle = new Bus( model, year, registrationNumber, double.Parse(specific));
            }
            else if (vehicleType == "Motorcycle")
            {
                vehicle = new Motorcycle( model, year, registrationNumber, double.Parse(specific));
            }

            if (vehicle != null)
            {
                vehicleShop.AddVehicle(vehicle);
                MessageBox.Show("Vehicle added.");
            }
        }

        private void btnShowList_Click(object sender, RoutedEventArgs e)
        {
            lbVehicleList.Items.Clear();
            foreach (var vehicle in vehicleShop.VehicleList)
            {
                lbVehicleList.Items.Add(vehicle.ToVehicleString());
            }
        }

        private void btnSaveToFile_Click(object sender, RoutedEventArgs e)
        {
            vehicleShop.SaveToFile("vehicle_list.txt");
            MessageBox.Show("Vehicle list saved.");
        }
    }
