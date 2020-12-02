using System;
using System.Collections.Generic;
using System.Text;

namespace HarryPotter
{
    public class Wizard
    {
        public string Name { get; set; }
        public string BloodStatus { get; set; }
        public bool DeathEater { get; set; }
        public bool DumbledoresArmy { get; set; }
       
        public Wizard()
        {
            BloodStatus = BloodStatusGenerator();
            DeathEater = DeathEaterGenerator();
            DumbledoresArmy = DumbledoresArmyGenerator();
            Name = string.Empty; 
        }

        public string BloodStatusGenerator()
        {
            Random random = new Random();
            int possibility = random.Next(101);

            if (possibility >= 0 && possibility < 60)
            {
                BloodStatus = "Halvblod";
            }
            else if (possibility >= 60 && possibility < 85)
            {
                BloodStatus = "Mugglarfödd";
            }
            else if (possibility >= 85 && possibility < 95)
            {
                BloodStatus = "Fullblod";
            }
            else 
            {
                BloodStatus = "Okänt";
            }
            return BloodStatus;
        }

        public bool DeathEaterGenerator()
        {
            Random random = new Random();
            int possibility = random.Next(101);

            if (BloodStatus == "Halvblod")
            {
                if (possibility >= 0 && possibility < 25)
                {
                    return true;
                }
                else
                {
                    return false;
                }             
            }

            if (BloodStatus == "Mugglarfödd")
            {
                if (possibility >= 0 && possibility < 15)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            if (BloodStatus == "Fullblod")
            {
                if (possibility >= 0 && possibility < 60)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            if (BloodStatus == "Okänt")
            {
                if (possibility >= 0 && possibility < 25)
                {
                    return true;
                }
                else
                {
                    return false;
                }                   
            }
            return DeathEater;
        }

        public bool DumbledoresArmyGenerator()
        {
            Random random = new Random();
            int possibility = random.Next(101);

            if (DeathEater == true)
            {
               if (possibility >= 0 && possibility < 25)
               {
                    return true;
               }
               else
               {
                    return false;
               }
            }
            else if (DeathEater == false)
            {
               if (possibility >= 0 && possibility < 45)
               {
                    return true;
               }
               else
               {
                    return false;
               }
            }
            return DumbledoresArmy;        
        }

        public override string ToString()
        {
            return Name;
        }
    }


}
