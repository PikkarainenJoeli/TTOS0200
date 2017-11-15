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

namespace Autotalli
{
    

    public partial class MainWindow : Window
    {

        private List<Car> cars; //muuttuja käytettävissä kaikissa luokan tapahtumankäsittelijöissä.
        private const string path = @"D:\H8897\Repo\AutotalliDemo\";
        public MainWindow()
        {
            //Tänne oodi joka suoritetaan ikkunan luonnissa
            InitializeComponent();
            cars = Carage.GetCars();
            ShowPic("autotalli.png");

            /*
            List<string> carBrands = new List<string>();
            foreach (var s in cars)
            {
                carBrands.Add(s.Brand);
            }*/
            

            var result = cars.Select(m => m.Brand).Distinct();

            cmbCarList.ItemsSource = result;

        }

        private void btnGetCars(object sender, RoutedEventArgs e)
        {
            //Pyydetään BL kerrokselta autot ja näytetään ne
            
            dgCars.ItemsSource = cars;

            
        }

        private void ShowPic(string url)
        {
            try
            {
                if (string.IsNullOrEmpty(url))
                {
                    url = "puuttuu.png";
                }
                //lisätään vakiopolku
                url = path + url;

                if (System.IO.File.Exists(url))
                {

                    BitmapImage pic = new BitmapImage();
                    pic.BeginInit();
                    pic.UriSource = new Uri(url);
                    pic.EndInit();

                    imgCars.Stretch = Stretch.Fill;
                    imgCars.Source = pic;
                }
                else
                {
                    MessageBox.Show("ei oo kuvaa");
                }

            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgCarsChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                //huom, olemme itse populoineet datagridin cars olioilla joten kukin datagridi jäsen on cars olion instanssi.
                object obj = dgCars.SelectedItem;
                
                if (obj != null)
                {
                    Car selected = (Car)obj;
                    
                    ShowPic(selected.URL);
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }



        private void btnGetAudisClick(object sender, RoutedEventArgs e)
        {
            try
            {
                //näkyviin pelkästää Brand = Audi

                var result = cars.Where(m => m.Brand.Contains(cmbCarList.Text));
                dgCars.ItemsSource = result;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
