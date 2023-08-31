# Numbers Match - The Rules

Number Match is an addictive puzzle game with simple rules: match pairs and clear the board to succeed. Playing Number Match is a useful pastime for your brain. 
How to play:

• The goal is to clear the board.

• Find pairs of equal numbers (1 and 1, 7 and 7) or pairs that add up to 10 (6 and 4, 8 and 2) on the number grid.

• Tap on the numbers one by one to cross out them and get points.

• You can connect pairs in adjacent horizontal, vertical and diagonal cells, as well as at the end of one line and the beginning of the next.

• You can add extra lines with the remaining numbers to the bottom.

• You win after all numbers are removed from the number puzzle grid.

There are a lot of ways to solve the puzzle. But it’s not as easy as it seems. Tease your brain and get the engaging experience!

# The project
The project has 2 forms - HomeScreen.cs and GameForm.cs - the home screen has 3 buttons - to start a new game, read the rules or exit the application, while the Game form contains the game itself and almost all of the game logic.
The project has 2 classes = Cell and Neighbour. The Cell class inherits from the Button class and has 2 methods - SolveCell which compares 2 cells checking if their values are the same or equal to 10 and isNeighbour which checks if two cells are neighbours by checking if they are contained in eachothers lists of neighbours.

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

The neighbour class only keep information about the Row,Column and Direction
 

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
The Game form contails all of the logic, creating the grid and adding the cells, finding each cells neigbours and changing cells neighbours every time the player solves two cells,removing solved rows, win/lose conditions, points, etc.

![image](https://github.com/PetarTrajanovski/Numbers-Match/assets/63553289/77523ac6-88f5-4f6c-b70d-95e3ea2b55fb)
![image](https://github.com/PetarTrajanovski/Numbers-Match/assets/63553289/cdc65c4f-828e-4bb0-8b2d-1c9363aa4d54)




