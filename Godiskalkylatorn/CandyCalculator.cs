using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Godiskalkylatorn
{
    public class CandyCalculator
    {

        public static List<Person> PersonList = new List<Person>(); //gör en ny lista av personer

        private void CandyDistribution (int candy)  
        {
            int split = candy / PersonList.Count;  //antal godisar delat på per person
            int splitRest = candy % PersonList.Count; //moudulus-tecknet, resten av godisarna efter jämn uppdelning.

            foreach (var person in PersonList)  //går igenom varje person i listan
            {
                person.Candies = +split;   //varför plus innan split?
                if (splitRest > 0)    //om det återstår rest så delas den ut
                {
                    person.Candies++;  //delar godisarna
                    splitRest--;   //delar ut resten, så länge det finns mer än 0 delas det ut tills den blir 0
                }
            }                   
        }

        public void CandyDistributionFirstName (int candy)  //metod för att fördela godisar enligt förnamn
        {
            PersonList = PersonList.OrderBy(x => x.FirstName).ToList(); 
            CandyDistribution(candy);
        }
        public void CandyDistributionLastName (int candy) // metod för att fördela godisar enligt efternamn
        {
            PersonList = PersonList.OrderBy(x => x.LastName).ToList();
            CandyDistribution(candy);
        }
        public void CandyDistributionAge (int candy) //metod för att fördela godisar enligt ålder
        {
            PersonList = PersonList.OrderBy(x => x.Age).ToList();
            CandyDistribution(candy);
        }

        public static void SaveName (string filename)  //metod för att spara personerna man lagt till i listan
        {
            List<Person> SavePeople = FileHandler.Open<List<Person>>(filename);
            foreach (Person save in SavePeople)  //går igenom varje person i listan och sparar
            {
                PersonList.Add(save);
            }
        }     
    }
}
