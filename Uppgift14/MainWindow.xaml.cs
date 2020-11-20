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

namespace Uppgift14
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

        private void btnAge_Click(object sender, RoutedEventArgs e)
        {

            string dateOfBirth = (txtBox.Text);
            bool onlyNumbers = CheckLetters(dateOfBirth);
            
            if (onlyNumbers == true)
            {
                int age = DateTime.Now.Year - int.Parse(txtBox.Text);
                MessageBox.Show($"Du är {age} år gammal.");
            }

            else if (onlyNumbers == false)
            {
                MessageBox.Show($"Du måste mata in enbart siffror!");
            }             
            
        }

        private bool CheckLetters(string dateOfBirth)
        {
            bool allNumbers = true;
            foreach (char numbers in dateOfBirth)
            {
                if (Char.IsLetter(numbers) == false)
                {
                    allNumbers = true;
                }
                else
                {
                    allNumbers = false;
                    break;
                }
                
            }
            return allNumbers;

        }




    }

    

}
