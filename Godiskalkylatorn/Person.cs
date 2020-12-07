using System;
using System.Collections.Generic;
using System.Text;

namespace Godiskalkylatorn
{
    public class Person
    {
        public int Age { get; set; } //get och set, samlar in och tilldelar värde, public för att var nåbar
        public int Candies { get; set; }  //skapat en property
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string first, string last, int age) //constructor som har inparametrarna first, last och age
        {
            FirstName = first;
            LastName = last;
            Age = age;
        }

        public override string ToString()  // metod för att göra så att namn och ålder skrivs ut istället för "firstName", "lastName" osv.
        {
            return ($"{FirstName} {LastName} ({Age} år): st {Candies}");
        }
    }    
}
