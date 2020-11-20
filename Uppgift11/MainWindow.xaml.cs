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

namespace Uppgift11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // så att procenten på progressbaren ändras med 5 % om man trycker mer eller mindre otur
        int värde = 5;
        public MainWindow()
        {
            InitializeComponent();

            // så att progressbaren börjar på 50 %
            prgBar.Value = 50;
        }

        private void lessBtn_Click(object sender, RoutedEventArgs e)
        {
            // för att progressbarens % ska minska med 5 % vid knapptryck
            prgBar.Value = prgBar.Value - värde;

            // det som visas ovanför progressbaren, dvs tex 45%
            procent.Content = $"{prgBar.Value} %";
        }

        private void moreBtn_Click(object sender, RoutedEventArgs e)
        {
            // för att progressbarens % ska öka med 5 % vid knapptryck
            prgBar.Value = prgBar.Value + värde;
            procent.Content = $"{prgBar.Value} %";
        }

        private void startBtn_Click(object sender, RoutedEventArgs e)
        {
            int wrongside = 0;
            int antalGånger = 0;
            int randomNumber = 0;
            int chance = Convert.ToInt32(prgBar.Value);

            Random tries = new Random();
            antalGånger = Convert.ToInt32(txtBox.Text);


            for (int i = 0; i < antalGånger; i++)
            {
                randomNumber = tries.Next(100);
                if (randomNumber <= chance)
                {
                    wrongside++;
                }

                lblRight.Content = $"{antalGånger - wrongside}"; 
                lblWrong.Content = $"{wrongside}";



















            }
        }
    }
}
