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
        //DateTime hourTime = new DateTime();
        int hour;
        //foodAnswer.Text = hour.ToString();

        DateTime time;


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
                    checkTime(11, 23, "Beanz");
                    checkTime(7, 14, "Brick City");
                    checkTime(7, 21, "College Grind");
                    checkTime(11, 24, "Commons");
                    checkTime(7, 20, "Ctrl Alt DELi");
                    checkTime(11, 21, "Hissho Sushi ");
                    checkTime(11, 20, "Global Grill");
                    checkTime(7, 20, "Gracie's");
                    checkTime(7, 23, "Java Wally's");
                    checkTime(7, 24, "Midnight Oil");
                    break;
                case DayOfWeek.Friday:
                    checkTime(7, 17, "Artesano");
                    checkTime(11, 20, "Salsa's");
                    checkTime(11, 23, "Beanz");
                    checkTime(10, 22, "Crossroads");
                    checkTime(7, 14, "Brick City");
                    checkTime(7, 21, "College Grind");
                    checkTime(7, 18, "Ctrl Alt DELi");
                    checkTime(11, 24, "Commons");
                    checkTime(11, 20, "Hissho Sushi");
                    checkTime(11, 20, "Global Grill");
                    checkTime(7, 20, "Gracie's");
                    checkTime(7, 21, "Java Wally's");
                    checkTime(7, 24, "Midnight Oil");
                    break;

                case DayOfWeek.Saturday:
                    if (answer == "Crossroads" || answer == "Brick City"|| answer == "Ctrl Alt DELi" ) //add restaurant name
                    {
                        foodAnswer.Text = answer + closed;
                    } else { 
                    checkTime(12, 24, "Commons");
                    checkTime(12, 20, "Salsa's");
                    checkTime(7, 18, "Artesano");
                    checkTime(11, 23, "Beanz");
                    checkTime(9, 21, "College Grind");
                    checkTime(12, 20, "Hissho Sushi");
                    checkTime(11, 15, "Global Grill");
                    checkTime(7, 20, "Gracie's");
                    checkTime(11, 21, "Java Wally's");
                    checkTime(10, 24, "Midnight Oil");
                    }
                    break;

                case DayOfWeek.Sunday:
                    if (answer == "Salsa's" || answer == "RITZ" || answer == "Brick City" || answer == "Artesano" || answer == "Beanz"|| answer == "Brick City" || answer == "Ctrl Alt DELi" || answer == "Hissho Sushi" || answer == "Global Grill") //add restaurant name
                    {
                        foodAnswer.Text = answer + closed;
                    } else { 
                    checkTime(12, 24, "Commons");
                    checkTime(9, 21, "College Grind");
                    checkTime(12, 20, "Crossroads");
                    checkTime(11, 19, "Gracie's");
                    checkTime(11, 21, "Java Wally's");
                    checkTime(10, 24, "Midnight Oil");
                    }
                    break;



                default:
                    foodAnswer.Text = "aaaaah";
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            time = DateTime.Now;
            label1.Text = time.ToString("h:mm");
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
            //hour = time.Hour;
            hour = 8;
            //debug.Text = hour.ToString();
            

            if ((hour >= 11 && hour <= 13) || (hour >= 17 && hour <= 19))
            {
                peakTime = true;
            }
            else
            {
                peakTime = false;
            }

            if (startTime <= hour && hour < endTime)
            {
                //debug.Text = peakTime.ToString();
                if (peakTime == true)
                {
                    foodAnswer.Text = answer + open + longLine;
                    //debug.Text = hour.ToString();
                }
                else if (peakTime == false)
                {
                    foodAnswer.Text = answer + open + shortLine;
                    //debug.Text = hour.ToString();
                }

            }
            else 
            {
                foodAnswer.Text = answer + closed;
                //debug.Text = hour.ToString();
                
            }
            
        }
    }
}
