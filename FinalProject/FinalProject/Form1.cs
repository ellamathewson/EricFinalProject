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

        string answer;
        DateTime hourTime = new DateTime();
        int hour;
        //foodAnswer.Text = hour.ToString();


        DayOfWeek dt = DateTime.Today.DayOfWeek;
        //foodAnswer.Text = "the day of the week is " + dt;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            answer = comboBox1.Text;

            //debug.Text = dt.ToString();

            switch (dt)
            {
                //For weekdays:
                case DayOfWeek.Monday:
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                    checkTime(11, 21, "Salsa's");
                    checkTime(10, 22, "Crossroads");
                    checkTime(7, 18, "Artesano");

                    break;
                case DayOfWeek.Friday:
                    checkTime(7, 17, "Artesano");
                    checkTime(11, 20, "Salsa's");
                    checkTime(10, 22, "Crossroads");
                    break;

                case DayOfWeek.Saturday:
                    if (answer == "Crossroads" ) //add restaurant name
                    {
                        foodAnswer.Text = answer + closed;
                    }
                    checkTime(12, 20, "Salsa's");
                    checkTime(7, 18, "Artesano");

                    break;

                case DayOfWeek.Sunday:
                    if (answer == "Salsa's" || answer == "RITZ" || answer == "Brick City" || answer == "Artesano") //add restaurant name
                    {
                        foodAnswer.Text = answer + closed;
                    }
                    checkTime(12, 20, "Crossroads");
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

        private void checkTime(int startTime, int endTime, string name)
        {
            hour = hourTime.Hour + 12;
            //debug.Text = hour.ToString();
            

            if ((hour >= 11 && hour <= 13) || (hour >= 17 && hour <= 19))
            {
                peakTime = true;
            }
            else { peakTime = false; }

            if (peakTime == true)
            {
                //debug.Text = "It is peak hours";
            }
            else
            {
                //debug.Text = "It is not peak hours";
            }


            if (startTime <= hour && hour <= endTime) //add restaurant name
            {
                //debug.Text = peakTime.ToString();
                if (peakTime == true)
                {
                    foodAnswer.Text = answer + open + longLine;
                }
                else
                {
                    foodAnswer.Text = answer + open + shortLine;
                }
            }
            else
            {
                foodAnswer.Text = answer + closed;
            }
        }
    }
}
