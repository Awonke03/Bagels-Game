using System.Windows.Forms;

namespace BagelsGame
{
    public partial class Bagels : Form
    {
        public Bagels()
        {
            InitializeComponent();
        }

        private void Bagels_Load(object sender, EventArgs e)
        {

            rtbhints.AppendText("Here are some Clues\n");
            rtbhints.AppendText("\nWhat I say:      That means:");
            rtbhints.AppendText("\n  Pico               One digit is correct but in the wrong position.");
            rtbhints.AppendText("\n  Fermi             One Digit is Correct and in the right position.");
            rtbhints.AppendText("\n  Bagels            No digit is correct.");
            rtbhints.AppendText("\n\n\n          NB: 10  Guesses to make");

        }

        public int guesses = 0;
        public void checkgues(string num, string guess)
        {
            try
            {
                if (num.Contains(guess[0]) || num.Contains(guess[1]) || num.Contains(guess[2]))
                {
                    bool f = false;
                    for (int i = 0; i < num.Length; i++)
                    {
                        if (num[i] == guess[i])
                            f = true;

                    }
                    if (f == true)
                        rtbguess.AppendText($"Guess #{guesses}: {guess} \nFermi\n");
                    else
                        rtbguess.AppendText($"Guess #{guesses}: {guess} \nPico\n");



                }
                else
                    rtbguess.AppendText($"Guess #{guesses}: {guess} \nBagels\n");

            }
            catch (Exception)
            {
                MessageBox.Show($"'{guess}' is a INVALID OPTION !!\n");

            }


        }
        Random random = new Random();
        string num;

        private void btnplay_Click(object sender, EventArgs e)
        {

            if (guesses == 0)
                num = Convert.ToString(random.Next(100, 1001));



            string guess = Convert.ToString((nudguess.Value));
            bool bf = false;
            if (guesses <= 10 && num.Equals(guess) != true)
            {
                guesses++;
                checkgues(num, guess);

                if (num.Equals(guess))
                {
                    MessageBox.Show("You got it!!");
                    bf = true;


                }
            }
            else if (guesses == 10 && bf != true)
            {

                MessageBox.Show($"OHH So Close!!!\nI was thinking of{num}", "You lose");
                DialogResult n = MessageBox.Show("Do you want to play with me again?", "Confirmation", MessageBoxButtons.YesNo);
                if (n == DialogResult.Yes)
                {
                    rtbguess.Clear();
                    btnplay.Enabled = true;
                    guesses = 0;

                }
                else if (n == DialogResult.No)
                {
                    btnplay.Enabled = false;

                }

            }
            else
            {
                MessageBox.Show($"You got it!!\nIt's {guess}");
                DialogResult n = MessageBox.Show("Do you want to play with me again?", "Confirmation", MessageBoxButtons.YesNo);
                if (n == DialogResult.Yes)
                {
                    rtbguess.Clear();
                    btnplay.Enabled = true;
                    guesses = 0;

                }
                else if (n == DialogResult.No)
                {
                    btnplay.Enabled = false;

                    MessageBox.Show("GOODBYE FRIEND !!!\nCOME AGAIN AND PLAY WITH Next Time!!!", "Good Bye");
                    Application.Exit();

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult n = MessageBox.Show("Are you sure want to Quit?", "Confirmation", MessageBoxButtons.YesNo);
            if (n == DialogResult.Yes)
            {

                btnplay.Enabled = false;
                MessageBox.Show("GOODBYE FRIEND !!!\nCOME AGAIN AND PLAY WITH Next Time!!!", "Good Bye");
                Application.Exit();

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            guesses = 0;
            rtbguess.Clear();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}