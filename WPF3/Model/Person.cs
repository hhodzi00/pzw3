using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WPF3.Model
{
    public class Person
    {
        public Person(string name,  string city)
        {
            this.Name = name;
            this.City = city;
        }

        public String  Name { get; set; }
        public string City { get; set; }




    }

}
