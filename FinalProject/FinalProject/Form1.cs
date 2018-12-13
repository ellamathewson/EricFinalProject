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

        string dayOfWeek;


        string answer;
        //DateTime hourTime = new DateTime();
        int hour;
        //foodAnswer.Text = hour.ToString();

        DateTime time;

        //nested dictionary from hell


        DayOfWeek dt = DateTime.Today.DayOfWeek;
        //foodAnswer.Text = "the day of the week is " + dt;

        public Dictionary<string, Dictionary<string, List<int>>> restaurant = new Dictionary<string, Dictionary<string, List<int>>>
        {
            {
                "Salsa's", new Dictionary<string, List<int>>
                {
                    {"Weekday", new List<int>
                        {
                            // Monday-Thursday
                            11, 21
                        }
                    },
                    {"Friday", new List<int>
                        {
                            // Friday
                            11, 20 
                        }
                    },
                    {"Saturday", new List<int>
                        {
                            // Saturday
                            12, 20 
                        }
                    },
                    {"Sunday", new List<int>
                        {
                            // Sundays
                            0, 0 
                        }
                    }
                }
            },
        {
                "Midnight Oil", new Dictionary<string, List<int>>
                {
                    {"Weekday", new List<int>
                        {
                            // Monday-Thursday
                            11, 24
                        }
                    },
                    {"Friday", new List<int>
                        {
                            // Friday
                            11, 24
                        }
                    },
                    {"Saturday", new List<int>
                        {
                            // Saturday
                            12, 24
                        }
                    },
                    {"Sunday", new List<int>
                        {
                            // Sundays
                            10, 12
                        }
                    }
                }


            },

            {
                "Global Grille", new Dictionary<string, List<int>>
                {
                    {"Weekday", new List<int>
                        {
                            // Monday-Thursday
                            11, 21
                        }
                    },
                    {"Friday", new List<int>
                        {
                            // Friday
                            11, 20
                        }
                    },
                    {"Saturday", new List<int>
                        {
                            // Saturday
                            12, 20
                        }
                    },
                    {"Sunday", new List<int>
                        {
                            // Sundays
                            0, 0
                        }
                    }
                }


            },
            {
                "Crossroads", new Dictionary<string, List<int>>
                {
                    {"Weekday", new List<int>
                        {
                            // Monday-Thursday
                            11, 22
                        }
                    },
                    {"Friday", new List<int>
                        {
                            // Friday
                            11, 18
                        }
                    },
                    {"Saturday", new List<int>
                        {
                            // Saturday
                            0,0
                        }
                    },
                    {"Sunday", new List<int>
                        {
                            // Sundays
                            12, 20
                        }
                    }
                }


            },
             {
                "Nathan's", new Dictionary<string, List<int>>
                {
                    {"Weekday", new List<int>
                        {
                            // Monday-Thursday
                            10, 18
                        }
                    },
                    {"Friday", new List<int>
                        {
                            // Friday
                            10, 17
                        }
                    },
                    {"Saturday", new List<int>
                        {
                            // Saturday
                            11, 14
                        }
                    },
                    {"Sunday", new List<int>
                        {
                            // Sundays
                            0,0
                        }
                    }
                }


            },

                {
                "Brick City", new Dictionary<string, List<int>>
                {
                    {"Weekday", new List<int>
                        {
                            // Monday-Thursday
                            7, 14
                        }
                    },
                    {"Friday", new List<int>
                        {
                            // Friday
                            7, 14
                        }
                    },
                    {"Saturday", new List<int>
                        {
                            // Saturday
                            0, 0
                        }
                    },
                    {"Sunday", new List<int>
                        {
                            // Sundays
                            0,0
                        }
                    }
                }


            },
                {
                "RITZ", new Dictionary<string, List<int>>
                {
                    {"Weekday", new List<int>
                        {
                            // Monday-Thursday
                           11 , 19
                        }
                    },
                    {"Friday", new List<int>
                        {
                            // Friday
                            11, 19
                        }
                    },
                    {"Saturday", new List<int>
                        {
                            // Saturday
                            0, 0
                        }
                    },
                    {"Sunday", new List<int>
                        {
                            // Sundays
                            0,0
                        }
                    }
                }


            },
                {
                "Gracie's", new Dictionary<string, List<int>>
                {
                    {"Weekday", new List<int>
                        {
                            // Monday-Thursday
                            7, 19
                        }
                    },
                    {"Friday", new List<int>
                        {
                            // Friday
                            7, 19
                        }
                    },
                    {"Saturday", new List<int>
                        {
                            // Saturday
                            7, 19
                        }
                    },
                    {"Sunday", new List<int>
                        {
                            // Sundays
                            11,19
                        }
                    }
                }


            },
                {
                "Beanz", new Dictionary<string, List<int>>
                {
                    {"Weekday", new List<int>
                        {
                            // Monday-Thursday
                            7, 23
                        }
                    },
                    {"Friday", new List<int>
                        {
                            // Friday
                            7, 23
                        }
                    },
                    {"Saturday", new List<int>
                        {
                            // Saturday
                            11, 23
                        }
                    },
                    {"Sunday", new List<int>
                        {
                            // Sundays
                            9,23
                        }
                    }
                }


            },
             {
                "College Grind", new Dictionary<string, List<int>>
                {
                    {"Weekday", new List<int>
                        {
                            // Monday-Thursday
                            7, 21
                        }
                    },
                    {"Friday", new List<int>
                        {
                            // Friday
                            7, 21
                        }
                    },
                    {"Saturday", new List<int>
                        {
                            // Saturday
                            9, 21
                        }
                    },
                    {"Sunday", new List<int>
                        {
                            // Sundays
                            9, 21
                        }
                    }
                }


            },
            {
                "Commons", new Dictionary<string, List<int>>
                {
                    {"Weekday", new List<int>
                        {
                            // Monday-Thursday
                            11, 24
                        }
                    },
                    {"Friday", new List<int>
                        {
                            // Friday
                            11, 24
                        }
                    },
                    {"Saturday", new List<int>
                        {
                            // Saturday
                            11, 24
                        }
                    },
                    {"Sunday", new List<int>
                        {
                            // Sundays
                            12, 24
                        }
                    }
                }


            },
                  {
                "Java Wally's", new Dictionary<string, List<int>>
                {
                    {"Weekday", new List<int>
                        {
                            // Monday-Thursday
                            7, 22
                        }
                    },
                    {"Friday", new List<int>
                        {
                            // Friday
                            7, 21
                        }
                    },
                    {"Saturday", new List<int>
                        {
                            // Saturday
                            11, 21
                        }
                    },
                    {"Sunday", new List<int>
                        {
                            // Sundays
                            11, 21
                        }
                    }
                }


            },
                  {
                "Hissho Sushi", new Dictionary<string, List<int>>
                {
                    {"Weekday", new List<int>
                        {
                            // Monday-Thursday
                            11, 21
                        }
                    },
                    {"Friday", new List<int>
                        {
                            // Friday
                            11, 20
                        }
                    },
                    {"Saturday", new List<int>
                        {
                            // Saturday
                            12, 20
                        }
                    },
                    {"Sunday", new List<int>
                        {
                            // Sundays
                            0,0
                        }
                    }
                }


            },  
            {
                "Ctrl Alt DELi", new Dictionary<string, List<int>>
                {
                    {"Weekday", new List<int>
                        {
                            // Monday-Thursday
                            7, 20
                        }
                    },
                    {"Friday", new List<int>
                        {
                            // Friday
                            7, 15
                        }
                    },
                    {"Saturday", new List<int>
                        {
                            // Saturday
                            0,0
                        }
                    },
                    {"Sunday", new List<int>
                        {
                            // Sundays
                            0,0
                        }
                    }
                }


            },
              {
                "Artesano", new Dictionary<string, List<int>>
                {
                    {"Weekday", new List<int>
                        {
                            // Monday-Thursday
                            7, 18
                        }
                    },
                    {"Friday", new List<int>
                        {
                            // Friday
                            7, 17
                        }
                    },
                    {"Saturday", new List<int>
                        {
                            // Saturday
                            10, 14
                        }
                    },
                    {"Sunday", new List<int>
                        {
                            // Sundays
                            0,0
                        }
                    }
                }


            }


        };

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
            checkDayOfWeek();


            //debug.Text = dt.ToString();


            switch (dt)
            {
                case DayOfWeek.Monday:
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                    int startTime = restaurant[answer][dayOfWeek][0];
                    int endTime = restaurant[answer][dayOfWeek][1];
                    checkTime(startTime, endTime, answer);

                    break;
                case DayOfWeek.Friday:
                    break;
                case DayOfWeek.Saturday:
                    break;
                case DayOfWeek.Sunday:
                    break;
                default:
                    break;
            }
        }

        public void checkDayOfWeek()
        {
            switch(dt)
            {
                case DayOfWeek.Monday:
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                    dayOfWeek = "Weekday";
                    break;
                case DayOfWeek.Friday:
                    dayOfWeek = "Friday";
                    break;
                case DayOfWeek.Saturday:
                    dayOfWeek = "Saturday";
                    break;
                case DayOfWeek.Sunday:
                    dayOfWeek = "Sunday";
                    break;
                default:
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
            hour = time.Hour;
            //hour = 23;
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
                    foodAnswer.Text = name + open + longLine;
                    //debug.Text = hour.ToString();
                }
                else if (peakTime == false)
                {
                    foodAnswer.Text = name + open + shortLine;
                    //debug.Text = hour.ToString();
                }

            }
            else 
            {
                foodAnswer.Text = name + closed;
                //debug.Text = hour.ToString();
                
            }
            
        }
    }
}
