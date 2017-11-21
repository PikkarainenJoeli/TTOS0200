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
        public MainWindow()
        {
            InitializeComponent();

        }

        private void btnBuy1(object sender, RoutedEventArgs e)
        {
            try
            {
                txtList.Text = "";

                int items = VisualTreeHelper.GetChildrenCount(GridItems);
                List<string> BuyList = new List<string>();

                foreach (CheckBox chk in GridItems.Children)
                {
                    if ((bool)chk.IsChecked)
                    {
                        BuyList.Add(chk.Content.ToString());
                    }
                }

                for (int i = 0; i < BuyList.Count; i++)
                {
                    txtList.Text += BuyList[i] +" ";
                }

            }
            
            

            catch (Exception)
            {

                throw;
            }

        }
    }
}
