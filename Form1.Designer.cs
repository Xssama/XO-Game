namespace Rock_Paper_Scissors_MiniGame
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPlayerTurn = new System.Windows.Forms.Label();
            this.butResetGame = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTheWinner = new System.Windows.Forms.Label();
            this.plGame = new System.Windows.Forms.Panel();
            this.butGame9 = new System.Windows.Forms.Button();
            this.butGame8 = new System.Windows.Forms.Button();
            this.butGame7 = new System.Windows.Forms.Button();
            this.butGame6 = new System.Windows.Forms.Button();
            this.butGame3 = new System.Windows.Forms.Button();
            this.butGame4 = new System.Windows.Forms.Button();
            this.butGame5 = new System.Windows.Forms.Button();
            this.butGame2 = new System.Windows.Forms.Button();
            this.butGame1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.plGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Rock_Paper_Scissors_MiniGame.Properties.Resources.LeftPanelNackGround_1_;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblPlayerTurn);
            this.panel1.Controls.Add(this.butResetGame);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblTheWinner);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 566);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(96, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 39);
            this.label2.TabIndex = 12;
            this.label2.Text = "Turn : ";
            // 
            // lblPlayerTurn
            // 
            this.lblPlayerTurn.AutoSize = true;
            this.lblPlayerTurn.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerTurn.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerTurn.Location = new System.Drawing.Point(81, 150);
            this.lblPlayerTurn.Name = "lblPlayerTurn";
            this.lblPlayerTurn.Size = new System.Drawing.Size(110, 39);
            this.lblPlayerTurn.TabIndex = 13;
            this.lblPlayerTurn.Text = "Player1";
            // 
            // butResetGame
            // 
            this.butResetGame.BackColor = System.Drawing.Color.DarkSlateGray;
            this.butResetGame.Font = new System.Drawing.Font("Mongolian Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butResetGame.Location = new System.Drawing.Point(48, 384);
            this.butResetGame.Name = "butResetGame";
            this.butResetGame.Size = new System.Drawing.Size(169, 94);
            this.butResetGame.TabIndex = 11;
            this.butResetGame.Text = "Reset The Game";
            this.butResetGame.UseVisualStyleBackColor = false;
            this.butResetGame.Click += new System.EventHandler(this.butResetGame_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(41, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 39);
            this.label1.TabIndex = 9;
            this.label1.Text = "The winner is : ";
            // 
            // lblTheWinner
            // 
            this.lblTheWinner.AutoSize = true;
            this.lblTheWinner.BackColor = System.Drawing.Color.Transparent;
            this.lblTheWinner.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTheWinner.Location = new System.Drawing.Point(59, 285);
            this.lblTheWinner.Name = "lblTheWinner";
            this.lblTheWinner.Size = new System.Drawing.Size(172, 39);
            this.lblTheWinner.TabIndex = 10;
            this.lblTheWinner.Text = "In Progress.";
            // 
            // plGame
            // 
            this.plGame.BackgroundImage = global::Rock_Paper_Scissors_MiniGame.Properties.Resources.background;
            this.plGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.plGame.Controls.Add(this.butGame9);
            this.plGame.Controls.Add(this.butGame8);
            this.plGame.Controls.Add(this.butGame7);
            this.plGame.Controls.Add(this.butGame6);
            this.plGame.Controls.Add(this.butGame3);
            this.plGame.Controls.Add(this.butGame4);
            this.plGame.Controls.Add(this.butGame5);
            this.plGame.Controls.Add(this.butGame2);
            this.plGame.Controls.Add(this.butGame1);
            this.plGame.Location = new System.Drawing.Point(295, -3);
            this.plGame.Name = "plGame";
            this.plGame.Size = new System.Drawing.Size(802, 570);
            this.plGame.TabIndex = 0;
            // 
            // butGame9
            // 
            this.butGame9.BackColor = System.Drawing.Color.DimGray;
            this.butGame9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butGame9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butGame9.Font = new System.Drawing.Font("Microsoft YaHei UI", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butGame9.ForeColor = System.Drawing.Color.Firebrick;
            this.butGame9.Location = new System.Drawing.Point(520, 358);
            this.butGame9.Name = "butGame9";
            this.butGame9.Size = new System.Drawing.Size(137, 89);
            this.butGame9.TabIndex = 8;
            this.butGame9.Tag = "9";
            this.butGame9.Text = "?";
            this.butGame9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.butGame9.UseVisualStyleBackColor = false;
            this.butGame9.Click += new System.EventHandler(this.button_click);
            // 
            // butGame8
            // 
            this.butGame8.BackColor = System.Drawing.Color.DimGray;
            this.butGame8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butGame8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butGame8.Font = new System.Drawing.Font("Microsoft YaHei UI", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butGame8.ForeColor = System.Drawing.Color.Firebrick;
            this.butGame8.Location = new System.Drawing.Point(330, 358);
            this.butGame8.Name = "butGame8";
            this.butGame8.Size = new System.Drawing.Size(137, 89);
            this.butGame8.TabIndex = 7;
            this.butGame8.Tag = "8";
            this.butGame8.Text = "?";
            this.butGame8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.butGame8.UseVisualStyleBackColor = false;
            this.butGame8.Click += new System.EventHandler(this.button_click);
            // 
            // butGame7
            // 
            this.butGame7.BackColor = System.Drawing.Color.DimGray;
            this.butGame7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butGame7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butGame7.Font = new System.Drawing.Font("Microsoft YaHei UI", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butGame7.ForeColor = System.Drawing.Color.Firebrick;
            this.butGame7.Location = new System.Drawing.Point(153, 358);
            this.butGame7.Name = "butGame7";
            this.butGame7.Size = new System.Drawing.Size(137, 89);
            this.butGame7.TabIndex = 6;
            this.butGame7.Tag = "7";
            this.butGame7.Text = "?";
            this.butGame7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.butGame7.UseVisualStyleBackColor = false;
            this.butGame7.Click += new System.EventHandler(this.button_click);
            // 
            // butGame6
            // 
            this.butGame6.BackColor = System.Drawing.Color.DimGray;
            this.butGame6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butGame6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butGame6.Font = new System.Drawing.Font("Microsoft YaHei UI", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butGame6.ForeColor = System.Drawing.Color.Firebrick;
            this.butGame6.Location = new System.Drawing.Point(520, 238);
            this.butGame6.Name = "butGame6";
            this.butGame6.Size = new System.Drawing.Size(137, 89);
            this.butGame6.TabIndex = 5;
            this.butGame6.Tag = "6";
            this.butGame6.Text = "?";
            this.butGame6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.butGame6.UseVisualStyleBackColor = false;
            this.butGame6.Click += new System.EventHandler(this.button_click);
            // 
            // butGame3
            // 
            this.butGame3.BackColor = System.Drawing.Color.DimGray;
            this.butGame3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butGame3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butGame3.Font = new System.Drawing.Font("Microsoft YaHei UI", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butGame3.ForeColor = System.Drawing.Color.Firebrick;
            this.butGame3.Location = new System.Drawing.Point(520, 112);
            this.butGame3.Name = "butGame3";
            this.butGame3.Size = new System.Drawing.Size(137, 89);
            this.butGame3.TabIndex = 4;
            this.butGame3.Tag = "3";
            this.butGame3.Text = "?";
            this.butGame3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.butGame3.UseVisualStyleBackColor = false;
            this.butGame3.Click += new System.EventHandler(this.button_click);
            // 
            // butGame4
            // 
            this.butGame4.BackColor = System.Drawing.Color.DimGray;
            this.butGame4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butGame4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butGame4.Font = new System.Drawing.Font("Microsoft YaHei UI", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butGame4.ForeColor = System.Drawing.Color.Firebrick;
            this.butGame4.Location = new System.Drawing.Point(153, 238);
            this.butGame4.Name = "butGame4";
            this.butGame4.Size = new System.Drawing.Size(137, 89);
            this.butGame4.TabIndex = 3;
            this.butGame4.Tag = "4";
            this.butGame4.Text = "?";
            this.butGame4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.butGame4.UseVisualStyleBackColor = false;
            this.butGame4.Click += new System.EventHandler(this.button_click);
            // 
            // butGame5
            // 
            this.butGame5.BackColor = System.Drawing.Color.DimGray;
            this.butGame5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butGame5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butGame5.Font = new System.Drawing.Font("Microsoft YaHei UI", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butGame5.ForeColor = System.Drawing.Color.Firebrick;
            this.butGame5.Location = new System.Drawing.Point(330, 238);
            this.butGame5.Name = "butGame5";
            this.butGame5.Size = new System.Drawing.Size(137, 89);
            this.butGame5.TabIndex = 2;
            this.butGame5.Tag = "5";
            this.butGame5.Text = "?";
            this.butGame5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.butGame5.UseVisualStyleBackColor = false;
            this.butGame5.Click += new System.EventHandler(this.button_click);
            // 
            // butGame2
            // 
            this.butGame2.BackColor = System.Drawing.Color.DimGray;
            this.butGame2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butGame2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butGame2.Font = new System.Drawing.Font("Microsoft YaHei UI", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butGame2.ForeColor = System.Drawing.Color.Firebrick;
            this.butGame2.Location = new System.Drawing.Point(330, 112);
            this.butGame2.Name = "butGame2";
            this.butGame2.Size = new System.Drawing.Size(137, 89);
            this.butGame2.TabIndex = 1;
            this.butGame2.Tag = "2";
            this.butGame2.Text = "?";
            this.butGame2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.butGame2.UseVisualStyleBackColor = false;
            this.butGame2.Click += new System.EventHandler(this.button_click);
            // 
            // butGame1
            // 
            this.butGame1.BackColor = System.Drawing.Color.DimGray;
            this.butGame1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butGame1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butGame1.Font = new System.Drawing.Font("Microsoft YaHei UI", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butGame1.ForeColor = System.Drawing.Color.Firebrick;
            this.butGame1.Location = new System.Drawing.Point(153, 112);
            this.butGame1.Name = "butGame1";
            this.butGame1.Size = new System.Drawing.Size(137, 89);
            this.butGame1.TabIndex = 0;
            this.butGame1.Tag = "1";
            this.butGame1.Text = "?";
            this.butGame1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.butGame1.UseVisualStyleBackColor = false;
            this.butGame1.Click += new System.EventHandler(this.button_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 573);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.plGame);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.plGame.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plGame;
        private System.Windows.Forms.Button butGame1;
        private System.Windows.Forms.Button butGame9;
        private System.Windows.Forms.Button butGame8;
        private System.Windows.Forms.Button butGame7;
        private System.Windows.Forms.Button butGame6;
        private System.Windows.Forms.Button butGame3;
        private System.Windows.Forms.Button butGame4;
        private System.Windows.Forms.Button butGame5;
        private System.Windows.Forms.Button butGame2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTheWinner;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button butResetGame;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPlayerTurn;
    }
}

