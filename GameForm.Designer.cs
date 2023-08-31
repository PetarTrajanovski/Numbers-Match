namespace Numbers_Match
{
    partial class GameForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            AddLines = new Button();
            buttonNewGame = new Button();
            statusStrip1 = new StatusStrip();
            labelSolvedPairs = new ToolStripStatusLabel();
            labelSolvedRows = new ToolStripStatusLabel();
            labelPoints = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            labelTimeLeft = new Label();
            TimeLeft = new Label();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(370, 530);
            panel1.TabIndex = 0;
            // 
            // AddLines
            // 
            AddLines.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            AddLines.Location = new Point(402, 12);
            AddLines.Name = "AddLines";
            AddLines.Size = new Size(90, 90);
            AddLines.TabIndex = 1;
            AddLines.Text = "Add Lines";
            AddLines.UseVisualStyleBackColor = true;
            AddLines.Click += AddLines_Click;
            // 
            // buttonNewGame
            // 
            buttonNewGame.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonNewGame.Location = new Point(402, 119);
            buttonNewGame.Name = "buttonNewGame";
            buttonNewGame.Size = new Size(90, 90);
            buttonNewGame.TabIndex = 6;
            buttonNewGame.Text = "New Game";
            buttonNewGame.UseVisualStyleBackColor = true;
            buttonNewGame.Click += buttonNewGame_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { labelSolvedPairs, labelSolvedRows, labelPoints });
            statusStrip1.Location = new Point(0, 536);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(502, 25);
            statusStrip1.TabIndex = 9;
            statusStrip1.Text = "statusStrip1";
            // 
            // labelSolvedPairs
            // 
            labelSolvedPairs.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelSolvedPairs.Name = "labelSolvedPairs";
            labelSolvedPairs.Size = new Size(137, 20);
            labelSolvedPairs.Text = "Solved Pairs: 0";
            // 
            // labelSolvedRows
            // 
            labelSolvedRows.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelSolvedRows.Name = "labelSolvedRows";
            labelSolvedRows.Size = new Size(139, 20);
            labelSolvedRows.Text = "Solved Rows: 0";
            // 
            // labelPoints
            // 
            labelPoints.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelPoints.Name = "labelPoints";
            labelPoints.Size = new Size(85, 20);
            labelPoints.Text = "Points: 0";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // labelTimeLeft
            // 
            labelTimeLeft.AutoSize = true;
            labelTimeLeft.Font = new Font("Showcard Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelTimeLeft.Location = new Point(402, 230);
            labelTimeLeft.Name = "labelTimeLeft";
            labelTimeLeft.Size = new Size(90, 21);
            labelTimeLeft.TabIndex = 10;
            labelTimeLeft.Text = "Time Left";
            // 
            // TimeLeft
            // 
            TimeLeft.AutoSize = true;
            TimeLeft.Font = new Font("Showcard Gothic", 21F, FontStyle.Regular, GraphicsUnit.Point);
            TimeLeft.Location = new Point(399, 251);
            TimeLeft.Name = "TimeLeft";
            TimeLeft.Size = new Size(93, 35);
            TimeLeft.TabIndex = 11;
            TimeLeft.Text = "00:00";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(502, 561);
            Controls.Add(TimeLeft);
            Controls.Add(labelTimeLeft);
            Controls.Add(statusStrip1);
            Controls.Add(buttonNewGame);
            Controls.Add(AddLines);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Number Match";
            Load += Form1_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button AddLines;
        private Button buttonNewGame;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel labelSolvedPairs;
        private System.Windows.Forms.Timer timer1;
        private Label labelTimeLeft;
        private Label TimeLeft;
        private ToolStripStatusLabel labelSolvedRows;
        private ToolStripStatusLabel labelPoints;
    }
}