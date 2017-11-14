using System;
using System.Collections.Generic;
using System.Linq;
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

namespace Teht1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public void AddVechile(string vechile)
        {
            switch (vechile)
            {


                case "Cars":

                    int cars = int.Parse(txtCars.Text);
                    cars++;
                    txtCars.Text = cars.ToString();
                    break;

                case "Trucks":

                    int trucks = int.Parse(txtTrucks.Text);
                    trucks++;
                    txtTrucks.Text = trucks.ToString();
                    break;


            }
        }


        public MainWindow()
        {
            InitializeComponent();
            

        }

        private void OnClick(object sender, RoutedEventArgs e)
        {

            try
            {
                var btn = sender as Button;
                string s = btn.Content.ToString();
                AddVechile(s);

            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);                          
            }

        }
    }
}
