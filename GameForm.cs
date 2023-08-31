using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Eventing.Reader;
using System.Linq.Expressions;
using System.Linq;
using System.Xml.Serialization;

namespace Numbers_Match
{
    public partial class GameForm : Form
    {
        public Cell[,] cell = new Cell[13, 9];
        Random rand = new Random();
        bool flag = true;

        public int totalSeconds { get; set; } = 600;

        Cell firstClick = new Cell();
        int cellCount = 0;
        public int solvedCells { get; set; } = 0;
        public int totalPoints { get; set; } = 0;
        public int solvedRows { get; set; } = 0;
        public int gridRows { get; set; } = 13;
        public int gridColumns { get; set; } = 9;


        public GameForm()
        {
            InitializeComponent();
            PopulateGrid();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        public void PopulateGrid()//Make the game grid and add cells to it
        {
            for (int row = 0; row < 13; row++)
            {
                for (int col = 0; col < 9; col++, cellCount++)
                {
                    cell[row, col] = new Cell(row, col);
                    cell[row, col].Height = 40;
                    cell[row, col].Width = 40;
                    cell[row, col].BackColor = Color.White;
                    cell[row, col].Location = new Point(40 * col, 40 * row);
                    cell[row, col].Click += CellClick;
                    cell[row, col].Enabled = false;
                    if (cellCount < 35)
                    {
                        cell[row, col].Text = rand.Next(1, 10).ToString();
                        cell[row, col].IsOcucupied = true;
                        cell[row, col].Enabled = true;
                    }
                    panel1.Controls.Add(cell[row, col]);
                }
            }
            cell = findNeighbours(cell);
        }

        private Cell[,] findNeighbours(Cell[,] cells) // Initial adding Neighbours to Cells
        {
            int rowNeighbour;
            int colNeighbour;

            for (int i = 0; i < gridRows; i++)
            {
                for (int j = 0; j < gridColumns; j++)
                {
                    Cell currentCell = cells[i, j];
                    List<Neighbour> neighboursList = new List<Neighbour>();

                    for (int dir = 1; dir <= 8; dir++)
                    {
                        Neighbour neighbourDirection = new Neighbour(-1, -1, dir);

                        if (dir == 1) //Gore Levo
                        {
                            rowNeighbour = currentCell.RowNumber - 1;
                            colNeighbour = currentCell.ColNumber - 1;
                            if (rowNeighbour >= 0 && colNeighbour >= 0 && rowNeighbour < gridRows && colNeighbour < gridColumns)
                            {
                                neighbourDirection.Row = rowNeighbour;
                                neighbourDirection.Column = colNeighbour;
                            }
                            neighboursList.Add(neighbourDirection);
                        }

                        else if (dir == 2)   //Gore
                        {
                            rowNeighbour = currentCell.RowNumber - 1;
                            colNeighbour = currentCell.ColNumber;
                            if (rowNeighbour >= 0 && colNeighbour >= 0 && rowNeighbour < gridRows && colNeighbour < gridColumns)
                            {
                                neighbourDirection.Row = rowNeighbour;
                                neighbourDirection.Column = colNeighbour;
                            }
                            neighboursList.Add(neighbourDirection);
                        }
                        else if (dir == 3) //Gore Desno
                        {
                            rowNeighbour = currentCell.RowNumber - 1;
                            colNeighbour = currentCell.ColNumber + 1;
                            if (rowNeighbour >= 0 && colNeighbour >= 0 && rowNeighbour < gridRows && colNeighbour < gridColumns)
                            {
                                neighbourDirection.Row = rowNeighbour;
                                neighbourDirection.Column = colNeighbour;
                            }
                            neighboursList.Add(neighbourDirection);
                        }
                        else if (dir == 4) //Desno
                        {
                            if (i < gridRows - 1 && j == gridColumns - 1)
                            {
                                rowNeighbour = currentCell.RowNumber + 1;
                                colNeighbour = 0;
                            }
                            else
                            {
                                rowNeighbour = currentCell.RowNumber;
                                colNeighbour = currentCell.ColNumber + 1;
                            }
                            if (rowNeighbour >= 0 && colNeighbour >= 0 && rowNeighbour < gridRows && colNeighbour < gridColumns)
                            {
                                neighbourDirection.Row = rowNeighbour;
                                neighbourDirection.Column = colNeighbour;
                            }
                            neighboursList.Add(neighbourDirection);
                        }
                        else if (dir == 5) //Dole Desno
                        {
                            rowNeighbour = currentCell.RowNumber + 1;
                            colNeighbour = currentCell.ColNumber + 1;
                            if (rowNeighbour >= 0 && colNeighbour >= 0 && rowNeighbour < gridRows && colNeighbour < gridColumns)
                            {
                                neighbourDirection.Row = rowNeighbour;
                                neighbourDirection.Column = colNeighbour;
                            }
                            neighboursList.Add(neighbourDirection);
                        }
                        else if (dir == 6) //Dole
                        {
                            rowNeighbour = currentCell.RowNumber + 1;
                            colNeighbour = currentCell.ColNumber;
                            if (rowNeighbour >= 0 && colNeighbour >= 0 && rowNeighbour < gridRows && colNeighbour < gridColumns)
                            {
                                neighbourDirection.Row = rowNeighbour;
                                neighbourDirection.Column = colNeighbour;
                            }
                            neighboursList.Add(neighbourDirection);
                        }
                        else if (dir == 7) //Dole Levo
                        {
                            rowNeighbour = currentCell.RowNumber + 1;
                            colNeighbour = currentCell.ColNumber - 1;
                            if (rowNeighbour >= 0 && colNeighbour >= 0 && rowNeighbour < gridRows && colNeighbour < gridColumns)
                            {
                                neighbourDirection.Row = rowNeighbour;
                                neighbourDirection.Column = colNeighbour;
                            }
                            neighboursList.Add(neighbourDirection);
                        }
                        else if (dir == 8) //Levo
                        {
                            if (i > 0 && j == 0)
                            {
                                rowNeighbour = currentCell.RowNumber - 1;
                                colNeighbour = gridColumns - 1;
                            }
                            else
                            {
                                rowNeighbour = currentCell.RowNumber;
                                colNeighbour = currentCell.ColNumber - 1;
                            }
                            if (rowNeighbour >= 0 && colNeighbour >= 0 && rowNeighbour < gridRows && colNeighbour < gridColumns)
                            {
                                neighbourDirection.Row = rowNeighbour;
                                neighbourDirection.Column = colNeighbour;
                            }
                            neighboursList.Add(neighbourDirection);
                        }
                    } 
                    currentCell.Neighbours = neighboursList;
                    cells[i, j] = currentCell;
                }
            }
            return cells;
        }

        private void CellClick(object? sender, EventArgs e)
        {
            Cell clickedButton = (Cell)sender;

            if (flag)
            {
                firstClick = clickedButton;
                flag = false;
                firstClick.Enabled = false;
                firstClick.BackColor = Color.Yellow;
            }
            else
            {

                if (clickedButton.isNeighbour(firstClick) && clickedButton.SolveCell(firstClick))
                {
                    cell = InheritNeighbours(clickedButton, firstClick, cell);
                    solvedCells++;
                    totalPoints += 2;
                    updateToolStrip();
                    if (CheckSolvedRow(firstClick.RowNumber))
                    {
                        cell = RemoveRow(firstClick.RowNumber, cell);
                                           
                    }
                    if (firstClick.RowNumber != clickedButton.RowNumber)
                    {
                        if (CheckSolvedRow(clickedButton.RowNumber))
                        {
                            cell = RemoveRow(clickedButton.RowNumber, cell);
                        }
                    }
                    CheckWinner();
                }
                else
                {
                    firstClick.Enabled = true;
                    firstClick.BackColor = Color.White;
                }
                flag = true;
            }
        }
        private Cell[,] InheritNeighbours(Cell first, Cell second, Cell[,] grid) //change cells' neighbours after 2 cells have been solved
        {
            foreach (var item in first.Neighbours.ToList()) // Inherit firstclick solved cells neighbours
            {
                if (item.Column != -1 && item.Row != -1)
                {
                    if (item.Direction == 1)
                    {
                        grid[item.Row, item.Column].Neighbours[4] = first.Neighbours[4];
                    }
                    else if (item.Direction == 2)
                    {
                        grid[item.Row, item.Column].Neighbours[5] = first.Neighbours[5];
                    }
                    else if (item.Direction == 3)
                    {
                        grid[item.Row, item.Column].Neighbours[6] = first.Neighbours[6];
                    }
                    else if (item.Direction == 4)
                    {
                        grid[item.Row, item.Column].Neighbours[7] = first.Neighbours[7];
                    }
                    else if (item.Direction == 5)
                    {
                        grid[item.Row, item.Column].Neighbours[0] = first.Neighbours[0];
                    }
                    else if (item.Direction == 6)
                    {
                        grid[item.Row, item.Column].Neighbours[1] = first.Neighbours[1];
                    }
                    else if (item.Direction == 7)
                    {
                        grid[item.Row, item.Column].Neighbours[2] = first.Neighbours[2];
                    }
                    else if (item.Direction == 8)
                    {
                        grid[item.Row, item.Column].Neighbours[3] = first.Neighbours[3];
                    }
                    
                }
            }
            foreach (var item in second.Neighbours.ToList()) 
            {
                if (item.Column != -1 && item.Row != -1)
                {
                    if (item.Direction == 1)
                    {
                        grid[item.Row, item.Column].Neighbours[4] = second.Neighbours[4];
                    }
                    else if (item.Direction == 2)
                    {
                        grid[item.Row, item.Column].Neighbours[5] = second.Neighbours[5];
                    }
                    else if (item.Direction == 3)
                    {
                        grid[item.Row, item.Column].Neighbours[6] = second.Neighbours[6];
                    }
                    else if (item.Direction == 4)
                    {
                        grid[item.Row, item.Column].Neighbours[7] = second.Neighbours[7];
                    }
                    else if (item.Direction == 5)
                    {
                        grid[item.Row, item.Column].Neighbours[0] = second.Neighbours[0];
                    }
                    else if (item.Direction == 6)
                    {
                        grid[item.Row, item.Column].Neighbours[1] = second.Neighbours[1];
                    }
                    else if (item.Direction == 7)
                    {
                        grid[item.Row, item.Column].Neighbours[2] = second.Neighbours[2];
                    }
                    else if (item.Direction == 8)
                    {
                        grid[item.Row, item.Column].Neighbours[3] = second.Neighbours[3];
                    }  
                }
            }
            return grid;
        }

        private bool CheckSolvedRow(int row)//Check if a row is solved/

        {
            for (int i = 0; i <= 8; i++)
            {
                if (cell[row, i].IsOcucupied && !cell[row, i].IsSolved)
                {
                    return false;
                }
            }
            totalPoints += 4;
            solvedRows++;
            updateToolStrip();
            return true;
        }

        private Neighbour FindNeighborInDirection(int direction,  int row, int column)
        {
            Neighbour neighbour = new Neighbour()
            {
                Direction = direction,
                Column = column,
                Row = row
            };

            if (direction == 1)
            {
                int rowN = row - 1; 
                int columnN = column - 1;

                if (rowN >= 0 && columnN >= 0)
                {
                    while (cell[rowN, columnN].IsOcucupied && cell[rowN, columnN].IsSolved)
                    {
                        rowN = rowN - 1; 
                        columnN = columnN - 1;
                        if (rowN < 0 || columnN < 0)
                        {
                            rowN = -1; 
                            columnN = -1;
                            break;
                        }
                    }
                }
                neighbour.Row = rowN;
                neighbour.Column = columnN;
            }
            else if (direction == 2)
            {
                int rowN = row - 1;
                int columnN = column;

                if (rowN >= 0)
                {
                    while (cell[rowN, columnN].IsOcucupied && cell[rowN, columnN].IsSolved)
                    {
                        rowN = rowN - 1;
                        if (rowN < 0)
                        {
                            rowN = -1;
                            columnN = -1;
                            break;
                        }
                    }
                }
                neighbour.Row = rowN;
                neighbour.Column = columnN;
            }
            else if (direction == 3)
            {
                int rowN = row - 1;
                int columnN = column + 1;

                if (rowN >= 0 && columnN <gridColumns)
                {
                    while (cell[rowN, columnN].IsOcucupied && cell[rowN, columnN].IsSolved)
                    {
                        rowN = rowN - 1;
                        columnN = columnN + 1;
                        if (rowN < 0 || columnN > gridColumns - 1)
                        {
                            rowN = -1;
                            columnN = -1;
                            break;
                        }
                    }
                }
                neighbour.Row = rowN;
                neighbour.Column = columnN;
            }
            else if (direction == 4)
            {
                int rowN = row;
                int columnN = column + 1;

                if (rowN >= 0 && columnN <= gridColumns - 1)
                {
                    while (cell[rowN, columnN].IsOcucupied && cell[rowN, columnN].IsSolved)
                    {
                        columnN = columnN + 1;
                        if (columnN == gridColumns)
                        {
                            rowN = rowN + 1;
                            columnN = 0;
                        }
                        if (columnN >= gridColumns && rowN >= gridRows)
                        {
                            rowN = -1;
                            columnN = -1;
                            break;
                        }
                    }
                }
                neighbour.Row = rowN;
                neighbour.Column = columnN;
            }
            else if (direction == 5)
            {
                int rowN = row + 1;
                int columnN = column + 1;

                if (rowN <= gridRows - 1 && columnN <= gridColumns - 1)
                {
                    while (cell[rowN, columnN].IsOcucupied && cell[rowN, columnN].IsSolved)
                    {
                        columnN = columnN + 1;
                        rowN = rowN + 1;
                        
                        if (columnN >= gridColumns || rowN >= gridRows)
                        {
                            rowN = -1;
                            columnN = -1;
                            break;
                        }
                    }
                }
                neighbour.Row = rowN;
                neighbour.Column = columnN;
            }
            else if (direction == 6)
            {
                int rowN = row + 1;
                int columnN = column + 1;

                if (rowN <= gridRows - 1 && columnN <= gridColumns - 1)
                {
                    while (cell[rowN, columnN].IsOcucupied && cell[rowN, columnN].IsSolved)
                    {
                        rowN = rowN + 1;
                        columnN = columnN + 1;
                        if (rowN >= gridRows || columnN >= gridColumns)
                        {
                            rowN = -1;
                            columnN = -1;
                            break;
                        }
                    }
                }
                neighbour.Row = rowN;
                neighbour.Column = columnN;
            }
            else if (direction == 7)
            {
                int rowN = row + 1;
                int columnN = column;

                if (rowN <= gridRows - 1)
                {
                    while (cell[rowN, columnN].IsOcucupied && cell[rowN, columnN].IsSolved)
                    {
                        rowN = rowN + 1;
                        if (rowN >= gridRows)
                        {
                            rowN = -1;
                            columnN = -1;
                            break;
                        }
                    }
                }
                neighbour.Row = rowN;
                neighbour.Column = columnN;
            }
            else if (direction == 8)
            {
                int rowN = row;
                int columnN = column - 1;

                if (columnN >= 0)
                {
                    while (cell[rowN, columnN].IsOcucupied && cell[rowN, columnN].IsSolved)
                    {
                        rowN = rowN - 1;
                        columnN = columnN - 1;
                        if (columnN < 0)
                        {
                            rowN = rowN - 1;
                            columnN = 0;
                        }
                        if (rowN < 0 || columnN < 0)
                        {
                            rowN = -1;
                            columnN = -1;
                            break;
                        }
                    }
                }
                neighbour.Row = rowN;
                neighbour.Column = columnN;
            }
            return neighbour;
        }//Check for new cell neighbours after a row if solved

        private Cell[,] RemoveRow(int rowForRemoval, Cell[,] cells) // Remove a row by shifting cells up
        {
            for (int i = rowForRemoval; i < 12; i++)
            {
              if (i >= 0)
              {
                 for (int col = 0; col <= 8; col++)
                 {
                            cell[i, col].Text = cell[i + 1, col].Text;
                            cell[i, col].Neighbours = cell[i + 1, col].Neighbours;
                            cell[i, col].IsSolved = cell[i + 1, col].IsSolved;
                            cell[i, col].Enabled = cell[i + 1, col].Enabled;
                            cell[i, col].IsOcucupied = cell[i + 1, col].IsOcucupied;
                            cell[i, col].BackColor = cell[i + 1, col].BackColor;  
                    }
                }
            }

            for (int i = 0; i < gridRows; i++)
            {
                for (int j = 0; j < gridColumns; j++)
                {
                    for (int k = 1; k <= 8; k++)
                    {
                        cells[i, j].Neighbours[k - 1] = FindNeighborInDirection(k, i, j);
                    }
                }
            }
            return cells;
        }

        private void AddLines_Click(object sender, EventArgs e)
        {
            Queue<String> numbersQueue = new Queue<String>();
            int numbersToAdd = 0;
            for (int row = 0; row < 13; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    if (cell[row, col].IsOcucupied && !cell[row, col].IsSolved)
                    {
                        numbersQueue.Enqueue(cell[row, col].Text);
                        numbersToAdd++;
                    }
                }
            }
            for (int row = 0; row < 13; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    if (!cell[row, col].IsOcucupied)
                    {
                        cell[row, col].Text = numbersQueue.Dequeue();
                        cell[row, col].IsOcucupied = true;
                        cell[row, col].Enabled = true;
                        numbersToAdd--;
                        if (numbersToAdd == 0) return;

                    }
                }
            }
        }//Add new cells

        private void buttonNewGame_Click(object sender, EventArgs e)//Start a new game
        {
            if (MessageBox.Show("Are you sure you want to start a new game? All progress will be lost.", "New Game", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Restart();
            }
            else
            {

            }
        }

        private void updateToolStrip()
        {
            labelSolvedPairs.Text = "Solved Pairs: " + solvedCells;
            labelSolvedRows.Text = "Solved Rows: " + solvedRows;
            labelPoints.Text = "Points: " + totalPoints;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (totalSeconds > 0)
            {
                totalSeconds--;
                int minutes = totalSeconds / 60;

                TimeLeft.Text = minutes.ToString("00") + ":" + (totalSeconds - minutes * 60).ToString("00");
            }
            else
            {
                timer1.Stop();
                DialogResult dr = MessageBox.Show("Time's up! Would you like to start a new game ?", "Game Over", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (dr == DialogResult.Cancel)
                {

                }
                else
                {
                    Application.Exit();
                }

            }
        }

        private void CheckWinner()
        {
            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 9; i++)
                {
                    if (!cell[i, j].IsSolved)
                    {
                        return;
                    }             
                }
            }
            timer1.Stop();
            DialogResult dr = MessageBox.Show("Congratilations ! You Won! Would you like to start a new game ?", "Game Over", MessageBoxButtons.YesNoCancel, MessageBoxIcon.None);
            if (dr == DialogResult.Yes)
            {
                Application.Restart();
            }
            else if (dr == DialogResult.Cancel)
            {

            }
            else
            {
                Application.Exit();
            }
        }

    }
}

