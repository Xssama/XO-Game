using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_Paper_Scissors_MiniGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Player2.Name = "Player 2";
            Player1.Name = "Player 1";
            Player1.BoxCheked = new Stack<int>();
            Player2.BoxCheked = new Stack<int>();

        }
         public struct Players
        {
            public string Name;
            public Stack<int> BoxCheked;
        };

         Players Player1;
         Players Player2;
         
         int ButtonsTunrnedCounter = 0;
        static bool OneOfTheChoicesIsInPos(Players player,  int pos)
        {
            if (player.BoxCheked.Count == 0)
            {
                return false;
            }
            foreach(int i in player.BoxCheked)
            {
                if (i == pos)
                {
                    return true;
                }
            }
            return false;
        }

         void CheckResult(Players player)
        {
            if (player.BoxCheked.Count < 3)
            {
                return;
            }

            else
            {
                //if one the choice is button 5
                if (OneOfTheChoicesIsInPos(player,5))
                {
                    if (OneOfTheChoicesIsInPos(player, 1))
                    {
                        if (OneOfTheChoicesIsInPos(player, 9))
                        {
                            lblTheWinner.Text = player.Name;
                            plGame.Enabled = false;
                            butGame1.BackColor = Color.Red;
                            butGame5.BackColor = Color.Red;
                            butGame9.BackColor = Color.Red;
                        }
                    }
                    if (OneOfTheChoicesIsInPos(player,3))
                    {
                        if(OneOfTheChoicesIsInPos(player,7))
                        {
                            lblTheWinner.Text = player.Name;
                            plGame.Enabled = false;
                            butGame3.BackColor = Color.Red;
                            butGame5.BackColor = Color.Red;
                            butGame7.BackColor = Color.Red;
                        }
                    }
                    if (OneOfTheChoicesIsInPos(player, 2))
                    {
                        if (OneOfTheChoicesIsInPos(player, 8))
                        {
                            lblTheWinner.Text = player.Name;
                            plGame.Enabled = false;
                            butGame2.BackColor = Color.Red;
                            butGame5.BackColor = Color.Red;
                            butGame8.BackColor = Color.Red;
                        }
                    }
                    if (OneOfTheChoicesIsInPos(player, 4))
                    {
                        if (OneOfTheChoicesIsInPos(player, 6))
                        {
                            lblTheWinner.Text = player.Name;
                            plGame.Enabled = false;
                            butGame4.BackColor = Color.Red;
                            butGame5.BackColor = Color.Red;
                            butGame6.BackColor = Color.Red;
                        }
                    }
                }
                //if one of the choices is 1
                if (OneOfTheChoicesIsInPos(player,1))
                {
                    if (OneOfTheChoicesIsInPos(player,2))
                    {
                        if (OneOfTheChoicesIsInPos(player,3))
                        {
                            lblTheWinner.Text = player.Name;
                            plGame.Enabled = false;
                            butGame1.BackColor = Color.Red;
                            butGame2.BackColor = Color.Red;
                            butGame3.BackColor = Color.Red;
                        }
                    }
                    if (OneOfTheChoicesIsInPos(player, 4))
                    {
                        if (OneOfTheChoicesIsInPos(player, 7))
                        {
                            lblTheWinner.Text = player.Name;
                            plGame.Enabled = false;
                            butGame1.BackColor = Color.Red;
                            butGame4.BackColor = Color.Red;
                            butGame7.BackColor = Color.Red;
                        }
                    }
                }

                //if one of the choices is 9
                if (OneOfTheChoicesIsInPos(player, 9))
                {
                    if (OneOfTheChoicesIsInPos(player, 6))
                    {
                        if (OneOfTheChoicesIsInPos(player, 3))
                        {
                            lblTheWinner.Text = player.Name;
                            plGame.Enabled = false;
                            butGame9.BackColor = Color.Red;
                            butGame6.BackColor = Color.Red;
                            butGame3.BackColor = Color.Red;
                        }
                    }
                    if (OneOfTheChoicesIsInPos(player, 8))
                    {
                        if (OneOfTheChoicesIsInPos(player, 7))
                        {
                            lblTheWinner.Text = player.Name;
                            plGame.Enabled = false;
                            butGame9.BackColor = Color.Red;
                            butGame8.BackColor = Color.Red;
                            butGame7.BackColor = Color.Red;
                        }
                    }
                }
            }
        }

        private Boolean WhoTurnisIt()
        {
            if (ButtonsTunrnedCounter == 0 || ButtonsTunrnedCounter % 2 == 1)
            {
                return true;
            }
           return false;
        }
        private void butGame1_Click_1(object sender, EventArgs e)
        {

        
            ButtonsTunrnedCounter++;
            if (WhoTurnisIt())
            {
                butGame1.Text = "X";
                Player1.BoxCheked.Push(Convert.ToInt16(butGame1.Tag));
                CheckResult(Player1);
            }
            else
            {
                butGame1.Text = "O";
                Player2.BoxCheked.Push(Convert.ToInt16(butGame1.Tag));
                CheckResult(Player2);
            }
            butGame1.Enabled = false;
        }

        private void butGame2_Click(object sender, EventArgs e)
        {
            ButtonsTunrnedCounter++;
            if (WhoTurnisIt())
            {
                butGame2.Text = "X";
                Player1.BoxCheked.Push(Convert.ToInt16(butGame2.Tag));
                CheckResult(Player1);
            }
            else
            {
                butGame2.Text = "O";
                Player2.BoxCheked.Push(Convert.ToInt16(butGame2.Tag));
                CheckResult(Player2);
            }
            butGame2.Enabled = false;
        }

        private void butGame3_Click_1(object sender, EventArgs e)
        {
            ButtonsTunrnedCounter++;
            if (WhoTurnisIt())
            {
                butGame3.Text = "X";
                Player1.BoxCheked.Push(Convert.ToInt16(butGame3.Tag));
                CheckResult(Player1);
            }
            else
            {
                butGame3.Text = "O";
                Player2.BoxCheked.Push(Convert.ToInt16(butGame3.Tag));
                CheckResult(Player2);
            }
            butGame3.Enabled = false;
        }

        private void butGame4_Click_1(object sender, EventArgs e)
        {
            ButtonsTunrnedCounter++;
            if (WhoTurnisIt())
            {
                butGame4.Text = "X";
                Player1.BoxCheked.Push(Convert.ToInt16(butGame4.Tag));
                CheckResult(Player1);
            }
            else
            {
                butGame4.Text = "O";
                Player2.BoxCheked.Push(Convert.ToInt16(butGame4.Tag));
                CheckResult(Player2);
            }
            butGame4.Enabled = false;
        }

        private void butGame5_Click(object sender, EventArgs e)
        {
            ButtonsTunrnedCounter++;
            if (WhoTurnisIt())
            {
                butGame5.Text = "X";
                Player1.BoxCheked.Push(Convert.ToInt16(butGame5.Tag));
                CheckResult(Player1);
            }
            else
            {
                butGame5.Text = "O";
                Player2.BoxCheked.Push(Convert.ToInt16(butGame5.Tag));
                CheckResult(Player2);
            }
            butGame5.Enabled = false;
        }

        private void butGame6_Click(object sender, EventArgs e)
        {
            ButtonsTunrnedCounter++;
            if (WhoTurnisIt())
            {
                butGame6.Text = "X";
                Player1.BoxCheked.Push(Convert.ToInt16(butGame6.Tag));
                CheckResult(Player1);
            }
            else
            {
                butGame6.Text = "O";
                Player2.BoxCheked.Push(Convert.ToInt16(butGame6.Tag));
                CheckResult(Player2);
            }
            butGame6.Enabled = false;
        }

        private void butGame7_Click(object sender, EventArgs e)
        {
            ButtonsTunrnedCounter++;
            if (WhoTurnisIt())
            {
                butGame7.Text = "X";
                Player1.BoxCheked.Push(Convert.ToInt16(butGame7.Tag));
                CheckResult(Player1);
            }
            else
            {
                butGame7.Text = "O";
                Player2.BoxCheked.Push(Convert.ToInt16(butGame7.Tag));
                CheckResult(Player2);
            }
            butGame7.Enabled = false;
        }

        private void butGame8_Click_1(object sender, EventArgs e)
        {
            ButtonsTunrnedCounter++;
            if (WhoTurnisIt())
            {
                butGame8.Text = "X";
                Player1.BoxCheked.Push(Convert.ToInt16(butGame8.Tag));
                CheckResult(Player1);
            }
            else
            {
                butGame8.Text = "O";
                Player2.BoxCheked.Push(Convert.ToInt16(butGame8.Tag));
                CheckResult(Player2);
            }
            butGame8.Enabled = false;
        }

        private void butGame9_Click(object sender, EventArgs e)
        {
            ButtonsTunrnedCounter++;
            if (WhoTurnisIt())
            {
                butGame9.Text = "X";
                Player1.BoxCheked.Push(Convert.ToInt16(butGame9.Tag));
                CheckResult(Player1);
            }
            else
            {
                butGame9.Text = "O";
                Player2.BoxCheked.Push(Convert.ToInt16(butGame9.Tag));
                CheckResult(Player2);
            }
            butGame9.Enabled = false;
        }

        private void butResetGame_Click(object sender, EventArgs e)
        {
            lblTheWinner.Text = "In Progress.";
            ButtonsTunrnedCounter = 0;

            plGame.Enabled = true;

            butGame1.Enabled = true;
            butGame1.Text = "?";
            butGame1.BackColor = Color.DimGray;

            butGame2.Enabled = true;
            butGame2.Text = "?";
            butGame2.BackColor = Color.DimGray;

            butGame3.Enabled = true;
            butGame3.Text = "?";
            butGame3.BackColor = Color.DimGray;

            butGame4.Enabled = true;
            butGame4.Text = "?";
            butGame4.BackColor = Color.DimGray;

            butGame5.Enabled = true;
            butGame5.Text = "?";
            butGame5.BackColor = Color.DimGray;

            butGame6.Enabled = true;
            butGame6.Text = "?";
            butGame6.BackColor = Color.DimGray;

            butGame7.Enabled = true;
            butGame7.Text = "?";
            butGame7.BackColor = Color.DimGray;

            butGame8.Enabled = true;
            butGame8.Text = "?";
            butGame8.BackColor = Color.DimGray;

            butGame9.Enabled = true;
            butGame9.Text = "?";
            butGame9.BackColor = Color.DimGray;

            while (Player1.BoxCheked.Count != 0)
            {
                Player1.BoxCheked.Pop();
            }
            while (Player2.BoxCheked.Count != 0)
            {
                Player2.BoxCheked.Pop();
            }

        }
    }
}