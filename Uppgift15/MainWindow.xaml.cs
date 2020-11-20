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

namespace Uppgift15
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
     

        private void convertButton_Click(object sender, RoutedEventArgs e)
        {
            string textInput = txtBox.Text;
            int vowelsAll = NumberOfVowels(textInput);
            vowelsBlock.Text = vowelsAll.ToString();
            convertedText.Text = Jibberish(txtBox.Text);

        }

        public string Jibberish (string textInput)
        {
            string translate = "";

            foreach (char vowel in textInput)
            {
                bool vowelSmall = SmallVowel(vowel);
                bool vowelBig = BigVowel(vowel);

                if (vowelSmall == true)
                {
                    translate += "ö";
                }
                else if (vowelBig == true)
                {
                    translate += "Ö";
                }
                else
                {
                    translate += vowel.ToString();
                }
               
            }
            return translate;
        }
        private int NumberOfVowels(string textInput)
        {
            int counter = 0;
            foreach (char letter in textInput)
            {
                bool ifVowel = IsVowel(letter);

                if (ifVowel == true)
                {
                    counter++;
                }

            }
            return counter;

        }

        public bool IsVowel (char character)
        {
            string allVowels = "aouåeiyäöAOUÅEIYÄÖ";
            bool theVowels = false;

            foreach (char chars in allVowels)
            {
                if (chars == character)
                {
                    theVowels = true;
                    break;

                }
            }
            return theVowels;
        }
        public bool SmallVowel (char character)
        {
            string smallVowels = "aouåeiyäö";
            bool ifSmallVowel = false;

            foreach (char chars in smallVowels)
            {
                if (chars == character)
                {
                    ifSmallVowel = true;
                    break;
                }


            }
            return ifSmallVowel;
        }
        public bool BigVowel (char character)
        {
            string bigVowels = "AOUÅEIYÄÖ";
            bool ifBigVowel = false;

            foreach (char chars in bigVowels)
            {
                if (chars == character)
                {
                    ifBigVowel = true;
                    break;
                }
            }
            return ifBigVowel;

        }

        private void clearBtn_Click(object sender, RoutedEventArgs e)
        {
            txtBox.Text = null;
            convertedText.Text = null;
            vowelsBlock.Text = null;


        }
    }
}
