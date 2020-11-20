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
        Random slump = new Random();

        int slumpital;
        int gissningar;

        public MainWindow()
        {
            InitializeComponent();

            gissaBtn.IsEnabled = false;
        }

        private void slumpBtn_Click(object sender, RoutedEventArgs e)
        {          
            slumpital = slump.Next(1000);
      
            gissaBtn.IsEnabled = true;
        }

        private void gissaBtn_Click(object sender, RoutedEventArgs e)
        {
            gissningar++;

            string tal = txtBox.Text;
            int guess = int.Parse(tal);
            

            if (guess == slumpital)
            {
                txtBlock.Text = $"Du gissade rätt! Du klarade det på {gissningar} försök";

            }

            else if (guess > 100 + slumpital)
            {
                txtBlock.Text = "Du gissade alldeles för högt!";

            }

            else if (guess < slumpital - 100)
            {
                txtBlock.Text = "Du gissade alldeles för lågt!";

            }

            else if (guess > slumpital && guess < slumpital + 100)
            {
                txtBlock.Text = "Du gissade för högt!";

            }

            else if (guess < slumpital && guess > slumpital - 100)
            {
                txtBlock.Text = "Du gissade för lågt!";

            }
                
            

        }
    }
}
