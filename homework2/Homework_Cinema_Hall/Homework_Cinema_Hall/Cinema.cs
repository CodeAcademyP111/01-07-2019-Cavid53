using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Cinema_Hall
{
    class Cinema
    {
        private static int ID;
        public string Name { get; set; }
        public string Address { get; set; }

        public Hall[] halls;

        public Cinema(string name,string address)
        {
            ID++;
            Name = name;
            Address = address;
        }
    }
}
