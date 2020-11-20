using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Uppgift12
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int counter = 0;
        double[] numbers = new double[5];

        public MainWindow()
        {
            InitializeComponent();

        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            double addNumber = double.Parse(btnNumber.Text);
        
            numbers[counter] = addNumber;
            counter++;
            boxNumbers.ItemsSource = null;
            boxNumbers.ItemsSource = numbers;

            btnNumber.Clear();


            if (counter == 5)
            {
                double medelvärde;
                medelvärde = (numbers[0] + numbers[1] + numbers[2] + numbers[3] + numbers[4]) / counter;

                btnValue.Text = medelvärde.ToString();

                btnOk.IsEnabled = false;

            }

        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            Array.Clear(numbers, 0, numbers.Length);

            boxNumbers.ItemsSource = null; 
            btnNumber.Clear();
            btnValue.Clear();
            counter = 0;

            btnOk.IsEnabled = true;

            btnNumber.Focusable = true;
            Keyboard.Focus(btnNumber);





            
        }
    }
}
