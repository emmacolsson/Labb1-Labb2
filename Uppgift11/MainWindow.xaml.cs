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
        int värde = 5;

        public MainWindow()
        {
            InitializeComponent();

            prgBar.Value = 50;
        }

        private void lessBtn_Click(object sender, RoutedEventArgs e)
        {
            prgBar.Value = prgBar.Value - värde;
            procent.Content = $"{prgBar.Value} %";
        }

        private void moreBtn_Click(object sender, RoutedEventArgs e)
        {
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
