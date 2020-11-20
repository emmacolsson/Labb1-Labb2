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

    class Ravenclaw
    {
      
       public string houseGhost;
       public string mascot;
       public string password;
    }

    class Gryffindor
    {
        public string houseGhost;
        public string mascot;
        public string password;

    }

    class Slytherin
    {
        public string houseGhost;
        public string mascot;
        public string password;

    }
    class Hufflepuff
    {
        public string houseGhost;
        public string mascot;
        public string password;

    }


    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Ravenclaw ravenclaw = new Ravenclaw();






        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
