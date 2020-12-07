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

namespace HarryPotter
{


    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Hogwarts hogwarts = new Hogwarts();
        Wizard wizard;
  
        public MainWindow()
        {
            InitializeComponent();
 
            cboHouses.Items.Add(hogwarts.Hufflepuff);
            cboHouses.Items.Add(hogwarts.Gryffindor);
            cboHouses.Items.Add(hogwarts.Ravenclaw);
            cboHouses.Items.Add(hogwarts.Slytherin);
            cboHouses.Items.Refresh();

            lblHufflepuffMascot.Content = hogwarts.Hufflepuff.Mascot;
            lblGryffindorMascot.Content = hogwarts.Gryffindor.Mascot;
            lblRavenclawMascot.Content = hogwarts.Ravenclaw.Mascot;
            lblSlytherinMascot.Content = hogwarts.Slytherin.Mascot;
        }

        private void btnChangePassword_Click(object sender, RoutedEventArgs e)
        {
            if (cboHouses.SelectedItem == hogwarts.Hufflepuff && hogwarts.Hufflepuff.PasswordSet(txtOldPassword.Text, txtNewPassword.Text) == true)
            {
                hogwarts.Hufflepuff.Password = txtNewPassword.Text;
                MessageBox.Show("Ditt lösenord har ändrats!");
            }
            else if (cboHouses.SelectedItem == hogwarts.Gryffindor && hogwarts.Gryffindor.PasswordSet(txtOldPassword.Text, txtNewPassword.Text) == true)
            {
                hogwarts.Gryffindor.Password = txtNewPassword.Text;
                MessageBox.Show("Ditt lösenord har ändrats!");
            }
            else if (cboHouses.SelectedItem == hogwarts.Ravenclaw && hogwarts.Ravenclaw.PasswordSet(txtOldPassword.Text, txtNewPassword.Text) == true)
            {
                hogwarts.Ravenclaw.Password = txtNewPassword.Text;
                MessageBox.Show("Ditt lösenord har ändrats!");
            }
            else if (cboHouses.SelectedItem == hogwarts.Slytherin && hogwarts.Slytherin.PasswordSet(txtOldPassword.Text, txtNewPassword.Text) == true)
            {
                hogwarts.Slytherin.Password = txtNewPassword.Text;
                MessageBox.Show("Ditt lösenord har ändrats!");
            }
            else
            {
                MessageBox.Show("Du har antingen skrivit in fel nuvarande lösenord eller så uppfyller du inte kraven för det nya lösenordet! Gör om gör rätt!");
            }
        }


        private void btnSortingHat_Click(object sender, RoutedEventArgs e)
        {

            wizard = new Wizard();
            wizard.Name = txtNewWizardName.Text;
            House house = hogwarts.SortingHat(wizard);
                      
            lstHufflepuff.ItemsSource = null;
            lstHufflepuff.ItemsSource = hogwarts.Hufflepuff.Members;
             
            lstRavenclaw.ItemsSource = null;
            lstRavenclaw.ItemsSource = hogwarts.Ravenclaw.Members;

            lstGryffindor.ItemsSource = null;
            lstGryffindor.ItemsSource = hogwarts.Gryffindor.Members;

            lstSlytherin.ItemsSource = null;
            lstSlytherin.ItemsSource = hogwarts.Slytherin.Members;

            WizardInfo(wizard);
            MessageBox.Show($"{wizard.Name} är numera medlem nummer {house.Members.Count} i {house}. Spöket {house.HouseGhost} kommer ta väl hand om dig.");
           
        }

        private void WizardInfo(Wizard wizard)
        {
            txtName.Text = wizard.Name;

            if (wizard.DumbledoresArmy == true)
            {
                chkArmy.IsChecked = true;
            }
            else
            {
                chkArmy.IsChecked = false;
            }

            if (wizard.DeathEater == true)
            {
                chkDeatheater.IsChecked = true;
            }
            else
            {
                chkDeatheater.IsChecked = false;
            }

        }

        private void lstHufflepuff_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            wizard = (Wizard)lstHufflepuff.SelectedItem;
            WizardInfo(wizard);
        }

        private void lstRavenclaw_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            wizard = (Wizard)lstRavenclaw.SelectedItem;
            WizardInfo(wizard);
        }
        private void lstGryffindor_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            wizard = (Wizard)lstGryffindor.SelectedItem;
            WizardInfo(wizard);
        }

        private void lstSlytherin_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            wizard = (Wizard)lstSlytherin.SelectedItem;
            WizardInfo(wizard);
        }
    }
}
   

