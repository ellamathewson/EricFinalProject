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

            if (hour == 12 && answer == "Salsa's") //add restaurant name
            {
                foodAnswer.Text = answer + open + longLine;
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
    }
}
