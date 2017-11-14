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

namespace Teht3
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

        private void OnClickCalc(object sender, RoutedEventArgs e)
        {
            try
            {
                int winArea;
                int glassArea;
                int framePeri;
                int frameArea;

                int winWidth = int.Parse(txtWinWidth.Text.ToString());
                int winHeight = int.Parse(txtWinHeight.Text.ToString());
                int frameWidth = int.Parse(txtFrameWidth.Text.ToString());

                if (winWidth < 300 || winHeight < 300 || winWidth > 3000 || winHeight > 3000)
                {
                    MessageBox.Show("Min 300 mm Max 3000mm");
                }
                else
                {
                    double scaler = 0.1;
                    winArea = winWidth * winHeight;

                    frameArea = (2 * (winWidth * frameWidth)) + (2 * (winHeight * frameWidth) - (4 * (frameWidth * frameWidth)));
                    framePeri = (2 * winWidth) + (2 * winHeight);
                    glassArea = winArea - frameArea;


                    txtWinA.Text = (winArea*scaler).ToString() + " cm^2";
                    txtGlassA.Text = (glassArea*scaler).ToString() + " cm^2";
                    txtFramePeri.Text = (framePeri * scaler).ToString() + " cm";

                    

                    WindowDraw.Height = winHeight * scaler;
                    WindowDraw.Width = winWidth * scaler;
                    WindowDraw.StrokeThickness = frameWidth * scaler;
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
