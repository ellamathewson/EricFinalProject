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
       //Strings for displying in label
        string closed = " is closed.";
        string open = " is open";
        string longLine = " and the line is long. Just don't go.";
        string shortLine = " and the line is short. GO!";

        //boolean for peak time
        Boolean peakTime = false;

        //string for day of week
        string dayOfWeek;

        //values for answer and hour
        string answer;
        int hour;

        //for getting hour 
        DateTime time;

        //gets current day of week
        DayOfWeek dt = DateTime.Today.DayOfWeek;

        //nested dictionary from hell
        //Dictionary holds restaurant name, and each name has days that have different hours represented by ints
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
        
        //when dropdown menu is changed
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //gets selected value
            answer = comboBox1.Text;
            //checks day of week 
            checkDayOfWeek();

            //start time grabs from the dictionary the first int in array in dictionary
            int startTime = restaurant[answer][dayOfWeek][0];
            //end time grabs from the dictionary the second int in the array in dictionary
            int endTime = restaurant[answer][dayOfWeek][1];
            //runs function by passing in these values
            checkTime(startTime, endTime, answer);

        }

        //Checks day of the week with a switch statement, sets string to value to be able to grab it from the dictionary
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

        //When form loads, grabs the current time and displays it on the screen
        private void Form1_Load(object sender, EventArgs e)
        {
            time = DateTime.Now;
            label1.Text = time.ToString("h:mm");
           
        }

        //Timer continues to update when on the form
        private void timer_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("h:mm");
        }

        //Function to check time and compare it to hours
        private void checkTime(int startTime, int endTime, string name)
        {
            //sets hour equal to current hour
            hour = time.Hour;

            //compares hour to peak time ints
            if ((hour >= 11 && hour <= 13) || (hour >= 17 && hour <= 19))
            {
                peakTime = true;
            }
            else
            {
                peakTime = false;
            }

            //if the hour is in between the values so the place is open
            if (startTime <= hour && hour < endTime)
            {
                //if the peak time evaluates to true then change food answers text accordingly 
                if (peakTime == true)
                {
                    foodAnswer.Text = name + open + longLine;
                }
                else if (peakTime == false)
                {
                    foodAnswer.Text = name + open + shortLine;
                }

            }
            else 
            {
                foodAnswer.Text = name + closed;                
            }
        }
    }
}
