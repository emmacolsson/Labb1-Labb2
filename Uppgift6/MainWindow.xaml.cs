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

namespace Uppgift6
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

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            double nummer1 = double.Parse(txtBox1.Text);
            double nummer2 = double.Parse(txtBox2.Text);
            double summa = nummer1 + nummer2;
            txtBox3.Text = Convert.ToString(summa);
            rubrik.Content = "Summa";
        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            double nummer1 = double.Parse(txtBox1.Text);
            double nummer2 = double.Parse(txtBox2.Text);
            double summa = nummer1 - nummer2;
            txtBox3.Text = Convert.ToString(summa);
            rubrik.Content = "Differens";
        }

        private void gånger_Click(object sender, RoutedEventArgs e)
        {
            double nummer1 = double.Parse(txtBox1.Text);
            double nummer2 = double.Parse(txtBox2.Text);
            double summa = nummer1 * nummer2;
            txtBox3.Text = Convert.ToString(summa);
            rubrik.Content = "Produkt";
        }

        private void delatmed_Click(object sender, RoutedEventArgs e)
        {
            double nummer1 = double.Parse(txtBox1.Text);
            double nummer2 = double.Parse(txtBox2.Text);
            double summa = nummer1 / nummer2;
            txtBox3.Text = Convert.ToString(summa);
            rubrik.Content = "Kvot";
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            txtBox1.Clear();
            txtBox2.Clear();
            txtBox3.Clear();
            rubrik.Content = "Resultat";
        }
    }
}
