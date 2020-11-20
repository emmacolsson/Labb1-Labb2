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

namespace Uppgift9a
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


        private void control_Click(object sender, RoutedEventArgs e)
        {
            bool vuxen = true;
            bool noVuxen = true;

            vuxen = adult.IsChecked.Value;
            noVuxen = noAdult.IsChecked.Value;

            int age = int.Parse(txtBox2.Text);
            string name = txtBox1.Text;
          
            {


                if (age <= 6 && vuxen)
                {
                    txtBox3.Content = $"Hej {name}! Du är {age} år gammal och det innebär att du \nfår se filmer med åldersgräns upp till 7 år \nmed vuxet sällskap";
                }

                else if (age <= 6 && noVuxen)
                {
                    txtBox3.Content = $"Hej {name}! Du är {age} år gammal och det innebär att du \nbara får se filmer som är barntilltåtna utan vuxet sällskap.";
                }

                else if (age >= 7 && age <= 10 && vuxen)
                {
                    txtBox3.Content = $"Hej {name}! Du är {age} år gammal och det innebär att du \nfår se filmer med åldersgräns upp till 11 år \nmed vuxet sällskap.";

                }

                else if (age >= 7 && age <= 10 && noVuxen)
                {
                    txtBox3.Content = $"Hej {name}! Du är {age} år gammal och det innebär att du \nbara får se filmer med åldersgräns upp till 7 år \nutan vuxet sällskap.";

                }

                else if (age >= 11 && age <= 14 && vuxen)
                {
                    txtBox3.Content = $"Hej {name}! Du är {age} år gammal och det innebär att du får \nse filmer med åldersgräns upp till 11 år, \näven om du har vuxet sällskap.";

                }
                else if (age >= 11 && age <= 14 && noVuxen)
                {
                    txtBox3.Content = $"Hej {name}! Du är {age} år gammal och det innebär att du får \nse filmer med åldersgräns upp till 11 år, utan vuxet sällskap.";

                }

                else if (age >= 15 && vuxen)
                {
                    txtBox3.Content = $"Hej {name}! Du är {age} år gammal och det innebär \natt du får se alla filmer.";

                }
                else if (age >= 15 && noVuxen)
                {
                    txtBox3.Content = $"Hej {name}! Du är {age} år gammal och det innebär \natt du får se alla filmer.";

                }







            }
        }


    }
}

