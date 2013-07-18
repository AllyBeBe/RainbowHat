using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoleyBoardScorekeeperv1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // will need to provide the ability to edit scores in case of mis post
        // reset radio buttons and current score labels when committed
        // reference calcoveralltotalscores();
        // Player or team 1 toss scores
        int p1scoreT1 = 0;
        int p1scoreT2 = 0;
        int p1scoreT3 = 0;
        int p1scoreTot = 0;
        int p1scoreGtot = 0;
        int p1numof1cnt = 0;
        int p1numof3cnt = 0;
        int p1numof5cnt = 0;
        int p1net1score = 0;
        int p1net3score = 0;
        int p1net5score = 0;
        
        // Player or team 2 toss scores
        int p2scoreT1 = 0;
        int p2scoreT2 = 0;
        int p2scoreT3 = 0;
        int p2scoreTot = 0;
        int p2scoreGtot = 0;
        int p2numof1cnt = 0;
        int p2numof3cnt = 0;
        int p2numof5cnt = 0;
        int p2net1score = 0;
        int p2net3score = 0;
        int p2net5score = 0;

        public void calcpscore()
        {
            //calculate p1 results
            if (pt1Toss1_1.Checked == true)
            {
                p1numof1cnt++;
                p1scoreT1 = 1;
            }
            if (pt1Toss1_3.Checked == true)
            {
                p1numof3cnt++;
                p1scoreT1 = 3;
            }
            if (pt1Toss1_5.Checked == true)
            {
                p1numof5cnt++;
                p1scoreT1 = 5;
            }
            if (pt1Toss2_1.Checked == true)
            {
                p1numof1cnt++;
                p1scoreT2 = 1;
            }
            if (pt1Toss2_3.Checked == true)
            {
                p1numof3cnt++;
                p1scoreT2 = 3;
            }
            if (pt1Toss2_5.Checked == true)
            {
                p1numof5cnt++;
                p1scoreT2 = 5;
            }
            if (pt1Toss3_1.Checked == true)
            {
                p1numof1cnt++;
                p1scoreT3 = 1;
            }
            if (pt1Toss3_3.Checked == true)
            {
                p1numof3cnt++;
                p1scoreT3 = 3;
            }
            if (pt1Toss3_5.Checked == true)
            {
                p1numof5cnt++;
                p1scoreT3 = 5;
            }

           // calculate p2 results  
            if (pt2Toss1_1.Checked == true)
            {
                p2numof1cnt++;
                p2scoreT1 = 1;
            }
            if (pt2Toss1_3.Checked == true)
            {
                p2numof3cnt++;
                p2scoreT1 = 3;
            }
            if (pt2Toss1_5.Checked == true)
            {
                p2numof5cnt++;
                p2scoreT1 = 5;
            }
            if (pt2Toss2_1.Checked == true)
            {
                p2numof1cnt++;
                p2scoreT2 = 1;
            }
            if (pt2Toss2_3.Checked == true)
            {
                p2numof3cnt++;
                p2scoreT2 = 3;
            }
            if (pt2Toss2_5.Checked == true)
            {
                p2numof5cnt++;
                p2scoreT2 = 5;
            }
            if (pt2Toss3_1.Checked == true)
            {
                p2numof1cnt++;
                p2scoreT3 = 1;
            }
            if (pt2Toss3_3.Checked == true)
            {
                p2numof3cnt++;
                p2scoreT3 = 3;
            }
            if (pt2Toss3_5.Checked == true)
            {
                p2numof5cnt++;
                p2scoreT3 = 5;
            }

           
        }

        public void reset_ints()
        {
            // reset ints to recalculate total current score
            p1scoreT1 = 0;
            p1scoreT2 = 0;
            p1scoreT3 = 0;
            p1scoreTot = 0;
            p1net1score = 0;
            p1net3score = 0;
            p1net5score = 0;
            p1numof1cnt = 0;
            p1numof3cnt = 0;
            p1numof5cnt = 0;
            // reset p2 ints 
            p2scoreT1 = 0;
            p2scoreT2 = 0;
            p2scoreT3 = 0;
            p2scoreTot = 0;
            p2numof1cnt = 0;
            p2numof3cnt = 0;
            p2numof5cnt = 0;
            p2net1score = 0;
            p2net3score = 0;
            p2net5score = 0;
        }

        public void calcnetscores()
        {
            // calc net scores
            if (p1numof1cnt > p2numof1cnt)
            {
                p1net1score = (p1numof1cnt - p2numof1cnt) * 1;
            }
            else if (p1numof1cnt < p2numof1cnt)
            {
                p2net1score = (p2numof1cnt - p1numof1cnt) * 1;
            }
            else
            {
                p1net1score = 0;
                p2net1score = 0;
            }
            if (p1numof3cnt > p2numof3cnt)
            {
                p1net3score = (p1numof3cnt - p2numof3cnt) * 3;
            }
            else if (p1numof3cnt < p2numof3cnt)
            {
                p2net3score = (p2numof3cnt - p1numof3cnt) * 3;
            }
            else
            {
                p1net3score = 0;
                p2net3score = 0;
            }
            if (p1numof5cnt > p2numof5cnt)
            {
                p1net5score = (p1numof5cnt - p2numof5cnt) * 5;
            }
            else if (p1numof5cnt < p2numof5cnt)
            {
                p2net5score = (p2numof5cnt - p1numof5cnt) * 5;
            }
            else
            {
                p1net5score = 0;
                p2net5score = 0;
            }
            p1scoreTot = p1net1score + p1net3score + p1net5score;
            p2scoreTot = p2net1score + p2net3score + p2net5score;

            p1TotScorelbl.Text = Convert.ToString(p1scoreTot);
            p2TotScorelbl.Text = Convert.ToString(p2scoreTot);

            //will need logic to incorporate p2 results
            //consider incorporating counts on for each player for each hole
            //i.e. p1 scored 2 1's p2 score 3 1's p2 gets 1pt
            //or consider matrix of all possible combinations (45*45) possible combs?
        }

        public void calcoveralltotscores()
        {
            if (p1scoreGtot < 21 & p2scoreGtot < 21)
            {
                p1scoreGtot = p1scoreTot + p1scoreGtot;
                p2scoreGtot = p2scoreTot + p2scoreGtot;
            }
            else if(p1scoreGtot == 21 & p2scoreGtot < 21)
            {
                MessageBox.Show("Player or Team 1 wins!");
            }
            else if (p2scoreGtot == 21 & p1scoreGtot < 21)
            {
                MessageBox.Show("Player or Team 2 wins!");
            }
            else if (p2scoreGtot == 21 & p1scoreGtot == 21)
            {
                MessageBox.Show("Tie, arm wrestle to break.");
            }
            else if (p1scoreGtot > 21)
            {
                MessageBox.Show("Player or Team 2 wins!");
            }
            else if (p2scoreGtot > 21)
            {
                MessageBox.Show("Player or Team 2 wins!");
            }

            p1Gtotscorelbl.Text = Convert.ToString(p1scoreGtot);
            p2Gtotscorelbl.Text = Convert.ToString(p2scoreGtot);
        }

        private void pt1Toss1_0_CheckedChanged(object sender, EventArgs e)
        {
            reset_ints();
            calcpscore();
        }

        private void pt1Toss1_1_CheckedChanged(object sender, EventArgs e)
        {
            reset_ints();
            calcpscore();
        }

        private void pt1Toss1_3_CheckedChanged(object sender, EventArgs e)
        {
            reset_ints();
            calcpscore();
        }

        private void pt1Toss1_5_CheckedChanged(object sender, EventArgs e)
        {
            reset_ints();
            calcpscore();
        }

        private void pt1Toss2_0_CheckedChanged(object sender, EventArgs e)
        {
            reset_ints();
            calcpscore();
        }

        private void pt1Toss2_1_CheckedChanged(object sender, EventArgs e)
        {
            reset_ints();
            calcpscore();
        }

        private void pt1Toss2_3_CheckedChanged(object sender, EventArgs e)
        {
            reset_ints();
            calcpscore();
        }

        private void pt1Toss2_5_CheckedChanged(object sender, EventArgs e)
        {
            reset_ints();
            calcpscore();
        }
        private void pt1Toss3_0_CheckedChanged(object sender, EventArgs e)
        {
            reset_ints();
            calcpscore();
        }

        private void pt1Toss3_1_CheckedChanged(object sender, EventArgs e)
        {
            reset_ints();
            calcpscore();
        }

        private void pt1Toss3_3_CheckedChanged(object sender, EventArgs e)
        {
            reset_ints();
            calcpscore();
        }

        private void pt1Toss3_5_CheckedChanged(object sender, EventArgs e)
        {
            reset_ints();
            calcpscore();
        }

        private void pt2Toss1_0_CheckedChanged(object sender, EventArgs e)
        {
            reset_ints();
            calcpscore();
        }
        private void pt2Toss1_1_CheckedChanged(object sender, EventArgs e)
        {
            reset_ints();
            calcpscore();
        }

        private void pt2Toss1_3_CheckedChanged(object sender, EventArgs e)
        {
            reset_ints();
            calcpscore();
        }

        private void pt2Toss1_5_CheckedChanged(object sender, EventArgs e)
        {
            reset_ints();
            calcpscore();
        }

        private void pt2Toss2_0_CheckedChanged(object sender, EventArgs e)
        {
            reset_ints();
            calcpscore();
        }

        private void pt2Toss2_1_CheckedChanged(object sender, EventArgs e)
        {
            reset_ints();
            calcpscore();
        }

        private void pt2Toss2_3_CheckedChanged(object sender, EventArgs e)
        {
            reset_ints();
            calcpscore();  
        }

        private void pt2Toss2_5_CheckedChanged(object sender, EventArgs e)
        {
            reset_ints();
            calcpscore();
        }
        private void pt2Toss3_0_CheckedChanged(object sender, EventArgs e)
        {
            reset_ints();
            calcpscore();  
        }

        private void pt2Toss3_1_CheckedChanged(object sender, EventArgs e)
        {
            reset_ints();
            calcpscore();
        }

        private void pt2Toss3_3_CheckedChanged(object sender, EventArgs e)
        {
            reset_ints();
            calcpscore();
        }

        private void pt2Toss3_5_CheckedChanged(object sender, EventArgs e)
        {
            reset_ints();
            calcpscore();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calcnetscores();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            calcoveralltotscores();
        }
    }
}