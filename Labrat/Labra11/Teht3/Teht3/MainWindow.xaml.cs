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
    /// 
        public class Lotto
        {

        public List<string> numbers = new List<string>();        

            public Lotto(string gameType,int draws)
            {
            try
            {
                 //------------------------------------------- LOTTO  
                if (gameType == "Lotto")
                {                   
                    string numberString = "";                  
                    int newRand;
                    Random rand = new Random();

                    for (int i = 0; i < draws; i++)
                    {
                        List<int> numbersList = new List<int>();
                        int[] oldRands = new int[100];
                        numberString = "";
                        
                        for (int j = 0; j < 7; j++)
                        {                           
                                newRand = rand.Next(1, 39 + 1);

                            if (oldRands.Contains(newRand)) {
                                j--;
                            }
                            else
                            {
                                numbersList.Add(newRand);
                                oldRands[j] = newRand;
                            }
                                                                                                                               
                        }

                        numbersList.Sort();
                        foreach (var n in numbersList)
                        {
                            numberString += n + " ";
                        }
                        numbers.Add(numberString);
                    }

                }

                //-------------------------------------------------------------VIKING 
                if (gameType == "Viking")
                {
                    string numberString = "";
                    int newRand;
                    Random rand = new Random();

                    for (int i = 0; i < draws; i++)
                    {
                        List<int> numbersList = new List<int>();
                        int[] oldRands = new int[100];
                        numberString = "";

                        for (int j = 0; j < 6; j++)
                        {
                            newRand = rand.Next(1, 49);

                            if (oldRands.Contains(newRand))
                            {
                                j--;
                            }
                            else
                            {
                                numbersList.Add(newRand);
                                oldRands[j] = newRand;
                            }

                        }

                        numbersList.Sort();
                        foreach (var n in numbersList)
                        {
                            numberString += n + " ";
                        }
                        numbers.Add(numberString);
                    }

                }

                //---------------------------------------------------------EUROJACKPOT
                if (gameType == "Eurojackpot")
                {
                    string numberString = "";
                    int newRand;
                    
                    Random rand = new Random();

                    for (int i = 0; i < draws; i++)
                    {
                        List<int> numbersList = new List<int>();
                        int[] oldRands = new int[100];                       
                        numberString = "";

                        for (int j = 0; j < 5; j++)
                        {
                            newRand = rand.Next(1, 51);

                            if (oldRands.Contains(newRand))
                            {
                                j--;
                            }
                            else
                            {
                                numbersList.Add(newRand);
                                oldRands[j] = newRand;
                            }

                        }
                        numbersList.Sort(); // sorttaus ennen tähtiä
                        //------------------------------------ tähtinumerot
                        int[] oldStars = new int[100];
                        int star;
                        for (int k = 0; k < 2; k++)
                        {
                            star = rand.Next(1, 11);

                            if (oldStars.Contains(star))
                            {
                                k--;
                            }
                            else
                            {
                                numbersList.Add(star);
                                oldStars[k] = star;
                                //MessageBox.Show("new star added" + star.ToString());
                            }
                            
                        }

                        
                        foreach (var n in numbersList)
                        {
                            numberString += n + " ";
                        }
                        numbers.Add(numberString);
                    }

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + "onclass");
            }
                

            }

        }



public partial class MainWindow : Window
    {



        public MainWindow()
        {
            InitializeComponent();
            string []games = new string [3]{ "Lotto","Viking","Eurojackpot"};
            cmbGames.ItemsSource = games;
        }



        private void btnDrawOnClick(object sender, RoutedEventArgs e)
        {
            try
            {                           
                string selectedGame = cmbGames.Text.ToString();               
                int draws = int.Parse(txtDraws.Text);            
                Lotto game = new Lotto(selectedGame,draws);               
                //MessageBox.Show(selectedGame + " " + draws.ToString());

                for (int i = 0; i < draws; i++)
                {                  
                    txtResults.Text += i + ": " + game.numbers[i] + "\n";
                }
                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + "onclick");
            }
            
        }

        private void btnClearOnClick(object sender, RoutedEventArgs e)
        {
            txtResults.Text = "";
        }
    }
}
