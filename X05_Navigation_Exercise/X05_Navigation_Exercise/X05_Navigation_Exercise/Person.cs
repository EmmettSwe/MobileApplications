using System;
using System.Collections.Generic;
using System.Text;

namespace X05_Navigation_Exercise
{
    public class Person
    {
        public string fName { get; set; }
        public string lName { get; set; }

        public Person(string fName, string lName) 
        {
            this.fName = fName;
            this.lName = lName;
        }
    }
}
