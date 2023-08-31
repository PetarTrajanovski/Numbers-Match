using Numbers_Match;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Numbers_Match
{
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            Form form = new GameForm();
            form.ShowDialog();
            this.Close();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRules_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\r\n• " +
                "The goal is to clear the board from numbers." +
                "\r\n• Find pairs of equal numbers (1 and 1, 7 and 7) or pairs that add up to 10 (6 and 4, 8 and 2) on the number grid." +
                "\r\n• Click on the numbers one by one to cross out them and get points." +
                "\r\n• " +
                "You can connect pairs in adjacent horizontal, vertical and diagonal cells, as well as at the end of one line and the beginning of the next." +
                "\r\n• When you run out of moves, you can add extra lines with the remaining numbers to the bottom." +
                "\r\n•" +
                "You win after all numbers are removed from the number puzzle grid." +
                "\r\n", "Rules");

        }
    }
}
