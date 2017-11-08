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

namespace WPFDemo
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

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            
            string nimi = TBo1.Text;
           
            TBl1.Text = nimi;
            
        }

        private void BtnEnlargeText_Click(object sender, RoutedEventArgs e)
        {
            //Suurennetaan texblocking kokoa
            TBl1.FontSize += 1;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBoxItem li = (ListBoxItem)CmbColors.SelectedItem;

            string color = li.Content.ToString();
            
            MessageBox.Show(color);

            var converter = new System.Windows.Media.BrushConverter();
            
            

            if (color == "Red")
            {
                Brush myBrush = Brushes.Red;
                TBl1.Foreground = myBrush;
            }
            else if (color == "Green")
            {
                Brush myBrush = Brushes.Green;
                TBl1.Foreground = myBrush;
            }
            else if (color == "Blue")
            {
                Brush myBrush = Brushes.Blue;
                TBl1.Foreground = myBrush;
            }

            /*var brush = (Brush)converter.ConvertFromString("#FFFFFF90");
            TBl1.Foreground = brush;*/
        }
    }
}
