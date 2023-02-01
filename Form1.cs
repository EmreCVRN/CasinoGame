using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_76742
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        int a, b, c, d,s, move, wins, loss, balance; // adding variables which ones we will need it 

        private void lbl_balance_Click(object sender, EventArgs e)
        {

        }

        private void btn_newgame_Click(object sender, EventArgs e)
        {
            textBox_spinPrice.Text = "Slot Machine";
            textBox_spinPrice.Enabled = true;
            textBox_spinPrice.Text = "";
            textBox_spinPrice.BackColor = Color.White;
            textBox_spinPrice.Focus();
            btn_play.Enabled = true;
            btn_play.Text = "Play";
            lbl_balance.Text = "Balance :$";
        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            if (btn_info.Text == "") ;

            MessageBox.Show("You will have $100 start money " +
                "\n If you want to win the game you have to get at least 3 pictures same otherwise you will lose " +
                "\n When you have 3 pictures same you will earn double " +
                "\n When you have 4 pictures same you will earn 4 times from your spin money " +
                "\n If you lose the game you will lose amonut of your spin money" +
                "\n Good Luck Have Fun !!!"); 
        }

        private void textBox_balance_TextChanged(object sender, EventArgs e)
        {
            4
        }

        // we need to create game variable...

        void Game_Result()
        {
           
            balance = Convert.ToInt32(textBox_balance.Text);

            if (a == b && b == c && c == d) // first win condition to get 3 pictures same
               
            {
                wins++;
                lbl_wins.Text = "Wins : " + wins; // if users win the game wins label keep the score
                balance += Convert.ToInt32(textBox_spinPrice.Text) * 2; // if users win the game get double price from spin price
                textBox_balance.Text = balance.ToString(); // it will change the balance
                btn_play.Text = "Continue Playing :";
                lbl_slotmachine.Text = "You Won ";

            }
            else if ((a == b && b ==c) ||( a ==b && b == d) || ( a == c && c == d ) || (b == c && c ==d ))// there is the condition for all 4 pictures can be same 
            {
                wins++;
                lbl_wins.Text = " Wins : " + wins;
                balance += Convert.ToInt32(textBox_spinPrice.Text) * 4; // if the user have all 4 pictures same user will get 4 times from spin price.
                btn_play.Text =("Continue Playing :");
                lbl_slotmachine.Text = "You Won ";
            }
            else
            {
                lbl_slotmachine.Text = "Try Again";
                loss++;
                lbl_loss.Text = "Loss : " + loss;
                balance -= Convert.ToInt32(textBox_spinPrice.Text);
                textBox_balance.Text = balance.ToString();

                textBox_spinPrice.Text = "" ;
                btn_play.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox_add_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(textBox_add.Text == "")
            {
                MessageBox.Show("You didn't enter any amount");
            }
            else if(Convert.ToInt32(textBox_add.Text) <=0 )
            {
                MessageBox.Show("Invalid balance entered ! ");
            }
            else
            {
                textBox_balance.Text = (Convert.ToInt32(textBox_balance.Text) + Convert.ToInt32(textBox_add.Text)).ToString();
            }
        }// working well too.

        private void timer1_Tick(object sender, EventArgs e)
        {
            move++;
            if (move < 30)
            {

                a = rnd.Next(4) + 1;
                b = rnd.Next(4) + 1;
                c = rnd.Next(4) + 1;
                d = rnd.Next(4) + 1;
                

                switch (a)
                {
                    case 1:
                        pictureBox1.Image = Properties.Resources.imgbin_casino_gambling_slot_machine_icon_diamond_chips_1siX49jPrGEKifb1kWNyzSchP;
                        break;
                    case 2:
                        pictureBox1.Image = Properties.Resources.gold_casino_slot_machine_with_cherry_symbol_icon_isolated_on_black_background_gambling_games_vector_700_2697232791;
                        break;
                    case 3:
                        pictureBox1.Image = Properties.Resources.images;
                        break;
                    case 4:
                        pictureBox1.Image = Properties.Resources.dollar;
                        break; // working well... It won't be stop because we didn't have anything for it. So let's make it for another pictures too.
                }
                switch (b)

                {
                    case 1:
                        pictureBox2.Image = Properties.Resources.imgbin_casino_gambling_slot_machine_icon_diamond_chips_1siX49jPrGEKifb1kWNyzSchP;
                                    break;
                    case 2:
                        pictureBox2.Image = Properties.Resources.gold_casino_slot_machine_with_cherry_symbol_icon_isolated_on_black_background_gambling_games_vector_700_2697232791;
                        break;
                    case 3:
                        pictureBox2.Image = Properties.Resources.images;
                        break;
                    case 4:
                        pictureBox2.Image = Properties.Resources.dollar;
                        break;
                }
                switch (c)
                {
                    case 1:
                        pictureBox3.Image = Properties.Resources.imgbin_casino_gambling_slot_machine_icon_diamond_chips_1siX49jPrGEKifb1kWNyzSchP;
                                      break;
                    case 2:
                        pictureBox3.Image = Properties.Resources.gold_casino_slot_machine_with_cherry_symbol_icon_isolated_on_black_background_gambling_games_vector_700_2697232791;
                        break;
                    case 3:
                        pictureBox3.Image = Properties.Resources.images;
                        break;
                    case 4:
                        pictureBox3.Image = Properties.Resources.dollar;
                        break;
                }
                switch (d)

                {
                    case 1:
                        pictureBox4.Image = Properties.Resources.imgbin_casino_gambling_slot_machine_icon_diamond_chips_1siX49jPrGEKifb1kWNyzSchP;
                                    break;
                    case 2:
                        pictureBox4.Image = Properties.Resources.gold_casino_slot_machine_with_cherry_symbol_icon_isolated_on_black_background_gambling_games_vector_700_2697232791;
                        break;
                    case 3:
                        pictureBox4.Image = Properties.Resources.images;
                        break;
                    case 4:
                        pictureBox4.Image = Properties.Resources.dollar;
                        break; //working nicely :)
                }
            }
            else
            {
                timer1.Enabled = false;
                move = 0; // it will stop our pictures. 
                Game_Result(); // calling function 
            }
        }
        


        private void btn_play_Click(object sender, EventArgs e)
        {
            if (textBox_spinPrice.Text == "")
            {
                MessageBox.Show("Please press the add balance button and enter your amount how much you want to put... ");

            }
            else if (Convert.ToInt32(textBox_spinPrice.Text) <= 0) // if the user enter price less than 0 
            {
                MessageBox.Show("Invalid deposit entered");
            }
            else if (Convert.ToInt32(textBox_spinPrice.Text) > Convert.ToInt32(textBox_balance.Text)) // if the user enter amount more than balance
            {
                MessageBox.Show("Insufficent balance ! ");
            }
            else                                                
            {
                timer1.Enabled = true;
                lbl_slotmachine.Text = "Casino";
                textBox_spinPrice.Enabled = false;
                textBox_spinPrice.BackColor = Color.LightBlue; // this code will change the background on spinprice box than we can undertand everything is okey 
                // Play button working well...

                // Everything is working perfectly :):)
                // Thanks for your time and watching my first c# project :)
            }
        }
    }
}
