using System;
using System.Windows.Forms;

namespace NumberGuess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CreateRandomNumber();
        }
        private void btnGuess_Click(object sender, EventArgs e)
        {
            int remainderCount = 0;
            remainderCount = int.Parse(lblCounter.Text);
            int enteredValue = int.Parse(txtValue.Text);

            if (enteredValue < 0 || enteredValue > 10)
            {
                MessageBox.Show("Enter a number in the correct range!");
                Clear();
            }
            else if (txtValue.Text == lblRandomNumber.Text)
            {
                lblRandomNumber.Show();
                MessageBox.Show("Success");
                Clear();
                CreateRandomNumber();
            }
            else
            {
                remainderCount--;
                Clear();
                if (remainderCount == 0)
                {
                    MessageBox.Show("The end!");
                    remainderCount = 5;
                }
                lblCounter.Text = remainderCount.ToString();
            }
        }

        /// <summary>
        /// TextBox is cleaning.
        /// </summary>
        void Clear()
        {
            txtValue.Clear();
        }


        /// <summary>
        /// Random number is generated.
        /// </summary>
        void CreateRandomNumber()
        {
            Random random = new Random();
            int rnd = random.Next(0, 10);
            lblRandomNumber.Text = rnd.ToString();
            lblRandomNumber.Hide();
        }
    }
}
