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

namespace Uppgift7
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

        private void btnCount_Click(object sender, RoutedEventArgs e)
        {
            int nummer1 = int.Parse(txtBox1.Text);
            int nummer2 = int.Parse(txtBox2.Text);

            int heltal = nummer1 / nummer2;          
            int rest = nummer1 % nummer2;

            txtBox3.Text = Convert.ToString(heltal);
            txtBox4.Text = Convert.ToString(rest);
        }

      
    }
}
