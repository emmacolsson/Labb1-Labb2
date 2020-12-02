using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Godiskalkylatorn
{
    public class CandyCalculator
    {

        public static List<Person> PersonList = new List<Person>();

        private void CandyDistribution (int candy)
        {
            int split = candy / PersonList.Count;
            int splitRest = candy % PersonList.Count;

            foreach (var person in PersonList)
            {
                person.Candies = +split;
                if (splitRest > 0)
                {
                    person.Candies++;
                    splitRest--;
                }
            }                   
        }

        public void CandyDistributionFirstName (int candy)
        {
            PersonList = PersonList.OrderBy(x => x.FirstName).ToList();
            CandyDistribution(candy);
        }
        public void CandyDistributionLastName (int candy)
        {
            PersonList = PersonList.OrderBy(x => x.LastName).ToList();
            CandyDistribution(candy);
        }
        public void CandyDistributionAge (int candy)
        {
            PersonList = PersonList.OrderBy(x => x.Age).ToList();
            CandyDistribution(candy);
        }

        public static void SaveName (string filename)
        {
            List<Person> SavePeople = FileHandler.Open<List<Person>>(filename);
            foreach (Person save in SavePeople)
            {
                PersonList.Add(save);
            }
        }     
    }
}
