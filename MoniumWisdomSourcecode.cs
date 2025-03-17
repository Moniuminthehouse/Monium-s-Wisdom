using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;

namespace Moniums_Wisdom
{
    public partial class Form1 : Form
    {
        public bool NoandYesmode = false;
        public DateTime CurrentDate { get { return DateTime.Now; } }

        public Form1()
        {
                InitializeComponent();
            Random random = new Random();
            int thyrandom = random.Next(1, 5);


            MessageBox.Show("Monium industries");
            switch (thyrandom)
            {
                case 1:
                    {
                        MessageBox.Show("Monium loves you");
                        break;
                    }
                case 2:
                    {
                        MessageBox.Show("Monium likely hates you");
                        break;
                    }
                case 3:
                    {
                        MessageBox.Show(CurrentDate.ToString("D"));
                        break;
                    }
                case 4:
                    {
                        MessageBox.Show("I hate you trolly");
                        break;
                    }
                case 5:
                    {
                        MessageBox.Show("Cluck cluck cluck!");
                        break;
                    }

            }
        }
  
         

        private void Wisdom_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int thyrandom = random.Next(1, 13);

            if(NoandYesmode == true)
            {
                NoandYesmodes();
            }
            else
            {
                switch (thyrandom)
                {
                    case 0:
                        {
                            break;
                        }
                    case 1:
                        {
                            label2.Text = string.Format("As trolly once said : indians are hatin on me");
                            break;
                        }
                    case 2:
                        {
                            label2.Text = string.Format("Winston churchill more like church is ill win he is ston");
                            break;
                        }
                    case 3:
                        {
                            label2.Text = string.Format("It has to be stated that the phone must be given to the man");
                            break;
                        }
                    case 4:
                        {
                            label2.Text = string.Format("This is monium's first app!");
                            break;
                        }
                    case 5:
                        {
                            label2.Text = string.Format("mate go study you have a math test tomorrow");
                            break;
                        }
                    case 6:
                        {
                            label2.Text = string.Format("CS majors on their way to the homeless shelter");
                            break;
                        }
                    case 7:
                        {
                            label2.Text = string.Format("Hi!");
                            break;
                        }
                    case 8:
                        {
                            label2.Text = string.Format("Fun fact : monium's first cat was nothing!");
                            break;
                        }
                    case 9:
                        {
                            label2.Text = string.Format("The final message! (for now)");
                            break;
                        }
                    case 10:
                        {
                            label2.Text = string.Format("I might leak Trolly's location next update");
                            break;
                        }
                    case 11:
                        {
                            label2.Text = string.Format("I love y'all");
                            break;
                        }
                    case 12:
                        {
                            label2.Text = string.Format("Is slavery a good or bad thing?");
                            break;
                        }
                }

            }
        }

        private void Randomnumber_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randoman = random.Next(0, 100);
            label1.Text = string.Format("Rosco Says {0}!", randoman);

            if (randoman == 0)
            {
                label1.Text = string.Format("Your day is extremely bad... probably");
            }
            else if (randoman == 99)
            {
                label1.Text = string.Format("{0}!!!!!", randoman);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NoandYesmode = true;
            if(NoandYesmode == true)
            {
                MessageBox.Show("No and Yes mode is now active!");
            }
            else
            {
                MessageBox.Show("Couldn't Commit changes");
            }
        }

        private void NoandYesmodes()
        {
            NoandYesmode = true;

            Random random = new Random();
            int noandyes = random.Next(0, 2);
            switch (noandyes)
            {
                case 0:
                    {
                        label2.Text = string.Format("No!");
                        break;
                    }
                case 1:
                    {
                        label2.Text = string.Format("Yes!");
                        break;
                    }
            }
            
        }

        private void Disability_Click(object sender, EventArgs e)
        {

            if(NoandYesmode == true)
            {
                MessageBox.Show("No And yes mode Has been disabled!");
                NoandYesmode = false;
            }
            else
            {
                MessageBox.Show("No and yes mode is already disabled!");
            }
        }
    }
}
