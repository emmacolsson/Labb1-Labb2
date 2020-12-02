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

namespace Godiskalkylatorn
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CandyCalculator candycalculator = new CandyCalculator();
        public string filename = "Godiskalkylatorn.json";

        public MainWindow()
        {
            InitializeComponent();      
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Person person = new Person(txtBoxFirstName.Text, txtBoxLastName.Text, int.Parse(txtBoxAge.Text));
            CandyCalculator.PersonList.Add(person);
            listBox.ItemsSource = CandyCalculator.PersonList;
            listBox.Items.Refresh();
            FileHandler.Save(CandyCalculator.PersonList, filename);
        }

        private void btnDistribution_Click(object sender, RoutedEventArgs e)
        {
            if (btnFirstName.IsChecked == true)
            {
                candycalculator.CandyDistributionFirstName(int.Parse(boxCandy.Text));
                listBox.ItemsSource = CandyCalculator.PersonList;
            }
            else if (btnLastName.IsChecked == true)
            {
                candycalculator.CandyDistributionLastName(int.Parse(boxCandy.Text));
                listBox.ItemsSource = CandyCalculator.PersonList;
            }
            else if (btnAge.IsChecked == true)
            {
                candycalculator.CandyDistributionAge(int.Parse(boxCandy.Text));
                listBox.ItemsSource = CandyCalculator.PersonList; 
            }
        }

        private void btnSaved_Click(object sender, RoutedEventArgs e)
        {
            CandyCalculator.SaveName(filename);
            listBox.ItemsSource = null;
            listBox.ItemsSource = CandyCalculator.PersonList;
        }
    }
}
