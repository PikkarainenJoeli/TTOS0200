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

namespace Teht2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnChange(object sender, TextChangedEventArgs e)
        {
           

            try
            {
                double d;
                if (double.TryParse(txtAmount.Text.ToString(), out d))
                {
                    double amount = double.Parse(txtAmount.Text.ToString());
                    ListBoxItem li = (ListBoxItem)cBoxCurrency.SelectedItem;
                    string s = li.Content.ToString();
                    double convertedValue;
                    switch (s)
                    {
                        case "Yhdysvallat USD":
                            txtConverted.Text = "Suomi EUR";
                            convertedValue = amount * 0.8997;
                            txtConvertedValue.Text = convertedValue.ToString("0.00");
                            break;

                        case "Suomi EUR":
                            txtConverted.Text = "Yhdysvallat USD";
                            convertedValue = amount * 1.1766;
                            txtConvertedValue.Text = convertedValue.ToString("0.00");
                            break;
                    }
                }
                else
                {
                    txtConvertedValue.Text = "NaN";
                }
    

               
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
