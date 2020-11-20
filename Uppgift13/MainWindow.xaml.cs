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

namespace Uppgift13
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

        private void countBtn_Click(object sender, RoutedEventArgs e)
        {
            string textInput = txtBox.Text;
            string character = characterBox.Text;
            int counter = 0;

            foreach (char letter in textInput)
            {
                if (letter == textInput[0])
                {
                    counter++;
                }

            }
            
           
            resultBox.Text = $"Bokstaven {character} hittades {counter} gånger.";

           

        }
    }
}
