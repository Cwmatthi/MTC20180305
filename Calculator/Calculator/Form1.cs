using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
       public Form1()
        {
            InitializeComponent();
        }
        public void checkvalue()
        {
            if (FirstValue.Text == "")
            {
                MessageBox.Show("Please enter an number");
                FirstValue.Focus();
            }
            else if (SecondValue.Text == "")
            {
                MessageBox.Show("Please enter an number");
                SecondValue.Focus();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void SecondValue_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Result_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddBut_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void SubBut_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void MultBut_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void DivBut_CheckedChanged(object sender, EventArgs e)
        {
            
        }

       

        private void Calcbut_Click(object sender, EventArgs e)
        {
            double valueOne = 0;
            double valueTwo = 0;
            bool number = true;

            number = (double.TryParse(FirstValue.Text, out valueOne) &&
                  double.TryParse(SecondValue.Text, out valueTwo));

            checkvalue();
           
            if (AddBut.Checked == true)
            {
                double sum;
                sum = int.Parse(FirstValue.Text) + int.Parse(SecondValue.Text);
                Result.Text = sum.ToString();
            }
            else if (SubBut.Checked == true )
            {
                double difference;
                difference = int.Parse(FirstValue.Text) - int.Parse(SecondValue.Text);
                Result.Text = difference.ToString();
            }
            else if (MultBut.Checked == true)
            {
                double product;
                product = int.Parse(FirstValue.Text) * int.Parse(SecondValue.Text);
                Result.Text = product.ToString();
            }
            else if (DivBut.Checked == true)
            {
                double quotient;
                quotient = int.Parse(FirstValue.Text) / int.Parse(SecondValue.Text);
                Result.Text = quotient.ToString();
            }
            else
            {
                MessageBox.Show("Need numerical values");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


    }

}
