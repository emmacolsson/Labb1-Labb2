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

namespace Uppgift10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // används för att slumpa fram något, läggs utanför metoderna för att nås överallt.
        Random slump = new Random();

        int slumpital;
        int gissningar;

        public MainWindow()
        {
            InitializeComponent();

            //gör så att gissa knappen är låst innan man slumpar tal
            gissaBtn.IsEnabled = false;
        }

        private void slumpBtn_Click(object sender, RoutedEventArgs e)
        {          
            //Next-metoden slumpar fram ett tal mellan 0 och upptill maxvärde, i detta fall 1000.
            slumpital = slump.Next(1000);


            //gör så att gissa knappen blir klickbar när man klickat på slumpa tal
            gissaBtn.IsEnabled = true;

        }

        private void gissaBtn_Click(object sender, RoutedEventArgs e)
        {
            // ++ för att gissningarna ska räknas upp när man gissat 
            gissningar++;

            string tal = txtBox.Text;
            int guess = int.Parse(tal);
            
            // om gissningen är rätt, dvs samma som det slumpade talet visas text nedan och även hur många gissningar som gjorts
            if (guess == slumpital)
            {
                txtBlock.Text = $"Du gissade rätt! Du klarade det på {gissningar} försök";

            }
            // om man gissar på mer än 100 över det slumpade talet visas text nedan
            else if (guess > 100 + slumpital)
            {
                txtBlock.Text = "Du gissade alldeles för högt!";

            }
            // om man gissar på mindre än 100 under det slumpade talet visas text nedan
            else if (guess < slumpital - 100)
            {
                txtBlock.Text = "Du gissade alldeles för lågt!";

            }
            // om man gissar på max 100 över det slumpade talet
            else if (guess > slumpital && guess < slumpital + 100)
            {
                txtBlock.Text = "Du gissade för högt!";

            }
            // om man gissar på max 100 under de slumpade talet
            else if (guess < slumpital && guess > slumpital - 100)
            {
                txtBlock.Text = "Du gissade för lågt!";

            }
                
            

        }
    }
}
