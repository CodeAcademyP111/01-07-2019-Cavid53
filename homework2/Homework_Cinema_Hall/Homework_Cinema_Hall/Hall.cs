using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Cinema_Hall
{
    class Hall
    {
        private static int ID;
        public string Name { get; set; }
        public float Price { get; set; }

        public Seat[,] Seats;

        public Hall(string name,float price)
        {
            Name = name;
            Price = price;
            Seats = new Seat[10, 10];
        }

        public void AddClients(Seat seat)
        {
            if(seat.ThePersonOfSeat.Money==Price && Seats[seat.Row, seat.Col] == null)
            {
                Seats[seat.Row, seat.Col] = seat;

                Console.WriteLine($"{seat.ThePersonOfSeat.Name} {seat.ThePersonOfSeat.Name}: Buyurun zala kece bilersiniz.");
            }
            else
            {
                Console.WriteLine($"{seat.ThePersonOfSeat.Name} {seat.ThePersonOfSeat.Name}: Teessuf ki daxil ola bilmersiz.");
            }
        }

    }
}
