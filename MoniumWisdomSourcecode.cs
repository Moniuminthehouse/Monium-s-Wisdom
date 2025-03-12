using System.ComponentModel;

namespace Moniums_Wisdom //name
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


 //background stuff
            this.BackgroundImage = Image.FromFile(@"C:\Users\souha\OneDrive\Images\Catfrom.png"); 
            

            this.BackgroundImageLayout = ImageLayout.Stretch; 


        }

        private void Wisdom_Click(object sender, EventArgs e)
        {

            Random random = new Random();
            int thyrandom = random.Next(1, 10);


            switch (thyrandom) //9 different messages all different from each other 
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

        private void AboutButton_Click(object sender, EventArgs e) //meaning of monium wisdom
        {
            MessageBox.Show("This is the first application made by monium! it includes 2 buttons one that has 10 messages for the users and one that picks a number between 1 - 100 send feedback to my instagram (moniuminthehouse)");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
