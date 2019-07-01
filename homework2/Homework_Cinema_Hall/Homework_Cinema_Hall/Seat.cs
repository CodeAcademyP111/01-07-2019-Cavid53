using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Cinema_Hall
{
    class Seat
    {
        private static int ID;
        public int Row { get; set; }
        public int Col { get; set; }

        public Person ThePersonOfSeat;
        public Seat(int row,int col,Person personseat)
        {
            Row = row;
            Col = col;
            ThePersonOfSeat = personseat;
        }
    }
}
