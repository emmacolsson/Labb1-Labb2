using System;
using System.Collections.Generic;
using System.Text;

namespace HarryPotter
{
    class Hogwarts
    {
        public Gryffindor Gryffindor { get; set; }
        public Hufflepuff Hufflepuff { get; set; }
        public Ravenclaw Ravenclaw { get; set; }
        public Slytherin Slytherin { get; set; }

        public Hogwarts()
        {
            Gryffindor = new Gryffindor();
            Hufflepuff = new Hufflepuff();
            Ravenclaw = new Ravenclaw();
            Slytherin = new Slytherin();
        }

        int counter = 0;
        public House SortingHat(Wizard wizard)
        {           

            if (counter == 0)
            {
                Hufflepuff.Members.Add(wizard);
                counter++;
                return Hufflepuff;
            }
            else if (counter == 1)
            {
                Ravenclaw.Members.Add(wizard);
                counter++;
                return Ravenclaw;
            }
            else if (counter == 2)
            {
                Gryffindor.Members.Add(wizard);
                counter++;
                return Gryffindor;
            }
            else if (counter == 3)
            {
                Slytherin.Members.Add(wizard);
                counter = 0;
                return Slytherin;
            }
            return null;  

        }

    }
}
