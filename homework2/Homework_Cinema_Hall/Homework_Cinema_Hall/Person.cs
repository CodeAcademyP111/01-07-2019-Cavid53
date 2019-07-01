using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Cinema_Hall
{
    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public float Money { get; set; }

        public Person(string name,string surname,float money)
        {
            Name = name;
            Surname = surname;
            Money = money;
        }
    }
}
