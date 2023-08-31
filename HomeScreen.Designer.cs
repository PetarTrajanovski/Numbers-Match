namespace Numbers_Match
{
    partial class HomeScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelTitle = new Label();
            buttonRules = new Button();
            buttonNewGame = new Button();
            buttonExit = new Button();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Showcard Gothic", 32.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitle.Location = new Point(102, 18);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(348, 53);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Number Match";
            // 
            // buttonRules
            // 
            buttonRules.Font = new Font("Showcard Gothic", 32.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRules.Location = new Point(158, 264);
            buttonRules.Name = "buttonRules";
            buttonRules.Size = new Size(286, 100);
            buttonRules.TabIndex = 1;
            buttonRules.Text = "Rules";
            buttonRules.UseVisualStyleBackColor = true;
            buttonRules.Click += buttonRules_Click;
            // 
            // buttonNewGame
            // 
            buttonNewGame.Font = new Font("Showcard Gothic", 32.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonNewGame.Location = new Point(158, 149);
            buttonNewGame.Name = "buttonNewGame";
            buttonNewGame.Size = new Size(286, 100);
            buttonNewGame.TabIndex = 2;
            buttonNewGame.Text = "Start";
            buttonNewGame.UseVisualStyleBackColor = true;
            buttonNewGame.Click += buttonNewGame_Click;
            // 
            // buttonExit
            // 
            buttonExit.Font = new Font("Showcard Gothic", 32.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonExit.Location = new Point(158, 382);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(286, 100);
            buttonExit.TabIndex = 10;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // HomeScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 545);
            Controls.Add(buttonExit);
            Controls.Add(buttonNewGame);
            Controls.Add(buttonRules);
            Controls.Add(labelTitle);
            Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "HomeScreen";
            Text = "Number Match";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Button buttonRules;
        private Button buttonNewGame;
        private Button buttonExit;
    }
}