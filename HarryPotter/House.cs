using System;
using System.Collections.Generic;
using System.Text;

namespace HarryPotter
{
    abstract class House
    {
        public string Name { get; set; }
        public string HouseGhost { get; set; }
        public string Mascot { get; set; }
        public string Password { get; set; }

        public List<Wizard> Members = new List<Wizard>(); //gör en lista
        Wizard wizard = new Wizard(); //gör ett nytt objekt av klassen wizard

        public Wizard Wizards (string wizardNew)
        {
            Members.Add(new Wizard { Name = wizardNew });
            return wizard;
        }

        public bool IsVowel(char character)  //kontrollerar om lösenordet innehåller vokal
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

        public bool IsKonsonant(char character)  //kollar om lösenordet innehåller konsonanter
        {
            string allKonsonant = "bcdfghjklmnpqrstvzxBCDFGHJKLMNPQRSTVZX";
            bool theKonsonants = false;

            foreach (char chars in allKonsonant)
            {
                if (chars == character)
                {
                    theKonsonants = true;
                    break;

                }
            }
            return theKonsonants;
        }

        public virtual bool LetterCount(string passwordChange)  //kollar så att lösenordet är minst 5 bokstäver
        {
            int counter = 0;
            bool amountRight = true;
            foreach (char letter in passwordChange)
            {
                counter++;

                if (counter >= 5)
                {
                    amountRight = true;
                }
                else
                {
                    amountRight = false;
                }

            }
            return amountRight;
        }

        public virtual bool PasswordCheck(string changePassword)  //kollar så att alla parametrar stämmer 
        {
            char characterLast = changePassword[changePassword.Length - 1];
            bool correctPassword = true;

            if (IsVowel(changePassword[0]) == true && LetterCount(changePassword) == true && IsKonsonant(characterLast) == true)
            {
                correctPassword = true;
            }
            else
            {
                correctPassword = false;

            }
            return correctPassword;
        }  

        public bool PasswordSet (string oldPassword, string newPassword) //sätter nytt lösenord
            {
            bool changedPassword = true;
            if (oldPassword == Password && PasswordCheck(newPassword) == true)
            {
                Password = newPassword;
                changedPassword = true;
            }
            else
            {
                changedPassword = false;
            }

            return changedPassword;
        }

        public override string ToString() //Gör så att namnet man skriver skrivs ut och inte själva filnamnet
        {
            return this.GetType().Name;
        }
    }
}
