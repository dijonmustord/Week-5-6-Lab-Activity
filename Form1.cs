using System.Reflection.Emit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] cars = { "car1", "car2", "car3", "car4", "car5", "car6", "car7", "car8", "car9" };
        int[] discount = { 10, 20, 30, 1000 };

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = cars[(Convert.ToInt32(textBox1.Text) - 1)];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cars.Length; i++)
            {
                label2.Text += Environment.NewLine + cars[i];
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int left = 0;
            int right = discount.Length - 1;
            int target = Convert.ToInt32(textBox3.Text);
            Boolean found = false;



            while (left <= right)
            {
                int middle = (left + right) / 2;

                if (discount[middle] == target)
                {
                    label3.Text = "Discount Found";
                    break;
                    found = true;
                }
                else if (discount[middle] < target)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;

                }

                if (!found)
                {
                    label3.Text = "Discount Not Found";
                }
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cars.Length; i++)
            {
                for (int j = 0; j < cars.Length; j++)
                {
                    label4.Text += Environment.NewLine + cars[i] + " " + cars[j];
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox4.Text);
            int combo = 1;

            for (int i = 0; i < n; i++)
            {
                combo = combo * 2;
            }

            label5.Text += Environment.NewLine + Convert.ToString(combo);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}