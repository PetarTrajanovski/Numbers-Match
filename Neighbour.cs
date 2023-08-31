using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers_Match
{
    public class Neighbour

    {
        public int Row { get; set; }
        public int Column { get; set; }
        public int Direction { get; set; }

       
        public Neighbour(int row, int column,int direction)
        {
            Row = row;
            Column = column;
            Direction = direction;
        }

        public Neighbour()
        {
        }
        public override string? ToString()
        {
            return "Direction " + Direction + " - Coordinates: " + Row + " " + Column;
        }
        public bool CompareNeighbours(Neighbour neighbour)
        {
            if (neighbour.Row == Row && neighbour.Column == Column) return true;
            else return false;
        }
    }
}
