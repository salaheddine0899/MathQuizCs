using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timedMathQuiz
{
    public partial class Form1 : Form
    {

        Random random = new Random();

        int addEnd1;
        int addEnd2;
        int subEnd1;
        int subEnd2;
        int proEnd1;
        int proEnd2;
        int divEnd1;
        int divEnd2;

        int sumResExp, subResExp,proResExp,divResExp;

        int timeLeft;
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void init()
        {
            addEnd1 = random.Next(11);
            addEnd2 = random.Next(11);
            plusLeftLabel.Text = addEnd1.ToString();
            plusRightLabel.Text = addEnd2.ToString();
            subEnd1 = random.Next(11);
            subEnd2 = random.Next(11);
            minusLeftLabel.Text = subEnd1.ToString();
            minusRightLabel.Text = subEnd2.ToString();
            proEnd1 = random.Next(11);
            proEnd2 = random.Next(11);
            prodLeftLabel.Text = proEnd1.ToString();
            prodRightLabel.Text=proEnd2.ToString();
            divEnd1 = random.Next(11);
            do
            {
                divEnd2 = random.Next(11);
            } while (divEnd2 == 0);
            divLeftLabel.Text = divEnd1.ToString();
            divRightLabel.Text = divEnd2.ToString();
        }

        private void start_timer()
        {
            timer1.Start();
            timeLeft = 20;
            timeLabel.Text = "20 seconds!";
            button1.Enabled = false;
        }

        private bool check_ansewrs()
        {
            sumResExp = addEnd1 + addEnd2;
            subResExp = subEnd1 - subEnd2;
            proResExp = proEnd1 * proEnd2;
            divResExp= (int)(divEnd1 / divEnd2);
            return (sumResExp==sumRes.Value)&&(subResExp==subRes.Value)
                &&(proResExp==multRes.Value)
                &&(divResExp==divRes.Value) ;
        }

        private void start_quiz(object sender, EventArgs e)
        {


            init();

            start_timer();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (check_ansewrs())
            {
                timeLabel.Text = "Well done!";
                timer1.Stop();
                button1.Enabled = true;
            }
            else if (timeLeft > 0)
            {
                timeLeft--;
                timeLabel.Text = timeLeft + " seconds";
            }
            else
            {
                timer1.Stop();
                timeLabel.Text = "Time's up!!";
                button1.Enabled = true;
            }
        }
    }
}
