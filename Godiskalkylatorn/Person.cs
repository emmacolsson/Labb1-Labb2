using System;
using System.Collections.Generic;
using System.Text;

namespace Godiskalkylatorn
{
    public class Person
    {
        public int Age { get; set; }
        public int Candies { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string first, string last, int age)
        {
            FirstName = first;
            LastName = last;
            Age = age;
        }

        public override string ToString()
        {
            return ($"{FirstName} {LastName} ({Age} år): st {Candies}");
        }


    }

   
    
}
