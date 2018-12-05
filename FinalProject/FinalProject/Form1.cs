using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Form1 : Form
    {
        string closed = " is closed.";
        string open = " is open";
        string longLine = " and the line is long. Just don't go.";
        string shortLine = " and the line is short. GO!";
        Boolean peakTime = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String answer = comboBox1.Text;
            var hourTime = new DateTime();
            int hour = hourTime.Hour + 12;
            //foodAnswer.Text = hour.ToString();

            
            DayOfWeek dt = DateTime.Today.DayOfWeek;
            //foodAnswer.Text = "the day of the week is " + dt;

            if ((hour >= 11 && hour <= 13) || (hour >= 17 && hour <= 19))
            {
                peakTime = true;
            }
            else { peakTime = false; }

            if(peakTime == true)
            {
                debug.Text = "It is peak hours";
            }
            else
            {
                debug.Text = "It is not peak hours";
            }
            

            switch (dt)
            {
                case DayOfWeek.Wednesday:
                    if (11 <= hour && hour <= 21 && answer == "Salsa's") //add restaurant name
                    {
                        foodAnswer.Text = answer + open + longLine;
                    }
                    
                    else {
                        foodAnswer.Text = answer + closed;
                    }
                    break;

                default:
                    foodAnswer.Text = "aaaaah";
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var time = DateTime.Now.ToString("h:mm");
            label1.Text = time;

            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            
            label1.Text = DateTime.Now.ToString("h:mm");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
