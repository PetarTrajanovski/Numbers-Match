using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers_Match
{
    public class Cell : Button
    {
        public int RowNumber { get; set; }
        public int ColNumber { get; set; }
        public bool IsOcucupied { get; set; } = false;
        public bool IsSolved { get; set; } = false;
        public List<Neighbour> Neighbours { get; set; } = new List<Neighbour> { };

        public Cell(int rowNumber, int colNumber)
        {
            RowNumber = rowNumber;
            ColNumber = colNumber;
        }
        public Cell() { } 
        public bool SolveCell(Cell second) // Check if the cells are equal or the sum of 10, and mark them as solved
        {
            if ((Int32.Parse(this.Text) + Int32.Parse(second.Text) == 10) || (this.Text.Equals(second.Text)))
            {
                this.BackColor = Color.Green;
                second.BackColor = Color.Green;
                this.Enabled = false;
                second.Enabled = false;
                this.IsSolved = true;
                second.IsSolved = true;
                return true;
            }
            else
            {
                this.Enabled = true;
                second.Enabled = true;
                return false;
            }
        }
        public bool isNeighbour(Cell second) // Check if either of the cells' lists of neigbours contain the cell
        {
            return Neighbours.Where(x => x.Row == second.RowNumber && x.Column == second.ColNumber).Any() ||
                    second.Neighbours.Where(x => x.Row == RowNumber && x.Column == ColNumber).Any();
        }
    }
}
  
