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

namespace WpfApp1
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



        private void OnClick(object sender, RoutedEventArgs e)
        {

            //Type t = sender.GetType();
            //string ts = t.ToString();



            string ts2 = sender.ToString();

            string es = e.Source.ToString();

            string es2 = e.RoutedEvent.Name;
            string es3 = e.Source.ToString();

            MessageBox.Show(es3);
          

            //TextBox1.Text = es;
        }
    }
}
