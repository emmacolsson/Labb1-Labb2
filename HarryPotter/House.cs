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

        public List<Wizard> Members = null;


        public bool IsVowel(char character)
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

        public bool IsKonsonant(char character)
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

        public virtual bool LetterCount(string passwordChange)
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

        public virtual bool PasswordCheck(string changePassword)
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

        public bool PasswordSet (string oldPassword, string newPassword)
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
    }
}
