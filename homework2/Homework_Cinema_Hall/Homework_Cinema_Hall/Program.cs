using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Cinema_Hall
{
    class Program
    {
        static void Main(string[] args)
        {
            Cinema cinema = new Cinema("Park bulvar", "Sahil m/s");
            Hall hall = new Hall("Cristal", 25);
            Person human = new Person("Javid", "Bashirov", 25);
            Person human2 = new Person("Mushfiq", "Eliyev", 25);
            Person human3 = new Person("Kamran", "Jabiyev", 25);
            Seat seat = new Seat(2, 2, human);
            Seat seat2 = new Seat(2, 3, human2);
            Seat seat3 = new Seat(2, 2, human3);

            hall.AddClients(seat);
            hall.AddClients(seat2);
            hall.AddClients(seat3);
        }
    }
}
