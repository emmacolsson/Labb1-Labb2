using System;
using System.Collections.Generic;
using System.Text;

namespace HarryPotter
{
    class Slytherin : House
    {
        public Slytherin()
        {
            Name = "Slytherin";
            HouseGhost = "Blodige baronen";
            Mascot = "Orm";
            Password = "Slytherin är bäst";

        }

        public override bool LetterCount(string passwordChange)
        {
            int counter = 0;
            bool amountRightSlyth = true;
            foreach (char letter in passwordChange)
            {
                counter++;

                if (counter >= 8)
                {
                    amountRightSlyth = true;
                }
                else
                {
                    amountRightSlyth = false;
                }

            }
            return amountRightSlyth;

        }

        public override bool PasswordCheck(string changePassword)
        {
            char characterLast = changePassword[changePassword.Length - 1];
            bool correctPassword = true;

            if (IsKonsonant(changePassword[0]) == true && LetterCount(changePassword) == true && IsKonsonant(characterLast) == true)
            {
                correctPassword = true;
            }
            else
            {
                correctPassword = false;

            }
            return correctPassword;
        }




    }

}
