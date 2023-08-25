using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace retirementcal
{
    public partial class Form1 : Form
    {
        public static Form1 instance;
        public Form1()
        {
            InitializeComponent();
            instance = this;
        }

        private void label10_Click(object sender, EventArgs e)
        {  }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(namebox.Text))
            {
                MessageBox.Show("Please enter your name.");
            }
            else if (string.IsNullOrEmpty(scenariobox.Text))
            {
                MessageBox.Show("Please enter your scenario.");
            }
            else if (string.IsNullOrEmpty(currentage.Text))
            {
                MessageBox.Show("Please enter your current age.");
            }
            else if (string.IsNullOrEmpty(retirementage.Text))
            {
                MessageBox.Show("Please enter your retirement age.");
            }
            else if (string.IsNullOrEmpty(currentsalary.Text))
            {
                MessageBox.Show("Please enter your annual household income.");
            }
            else if (string.IsNullOrEmpty(retirenestegg.Text))
            {
                MessageBox.Show("Please enter your years of retirement income.");
            }
            else if (string.IsNullOrEmpty(incometoretire.Text))
            {
                MessageBox.Show("Please enter your annual retirement savings.");
            }
            else if (string.IsNullOrEmpty(incomeincre.Text))
            {
                MessageBox.Show("Please enter your expected increased income.");
            }
            else if (string.IsNullOrEmpty(activereturnrate.Text))
            {
                MessageBox.Show("Please enter your average annual return rate.");
            }
            else if (string.IsNullOrEmpty(duringreturnrate.Text))
            {
                MessageBox.Show("Please enter your return rate during retirement.");
            }
            else if (string.IsNullOrEmpty(withdrawal.Text))
            {
                MessageBox.Show("Please enter your withdrawal after retirement.");
            }
            else
            {
                float[] ivalue = new float[9];
                ivalue[0] = int.Parse(currentage.Text);
                ivalue[1] = int.Parse(retirementage.Text);
                ivalue[2] = int.Parse(currentsalary.Text);
                ivalue[3] = int.Parse(retirenestegg.Text);
                ivalue[4] = int.Parse(incometoretire.Text);
                ivalue[5] = int.Parse(incomeincre.Text);
                ivalue[6] = int.Parse(duringreturnrate.Text);
                ivalue[7] = int.Parse(activereturnrate.Text);
                ivalue[8] = int.Parse(withdrawal.Text); 
                Form2 form = new Form2(ivalue);
                form.Show();
                Form2.instance.lab.Text = namebox.Text;
                Form2.instance.lab1.Text = scenariobox.Text;
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(currentage.Text, "[^0-9]"))
            { 
                MessageBox.Show("Please enter numbers only.");
                currentage.Text = currentage.Text.Remove(currentage.Text.Length - 1);
            }
 
        }

        private void annsave_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(incometoretire.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter numbers only.");
                incometoretire.Text = incometoretire.Text.Remove(incometoretire.Text.Length - 1);
            }
        }

        private void retirementage_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(retirementage.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter numbers only.");
                retirementage.Text = retirementage.Text.Remove(retirementage.Text.Length - 1);
            }
        }

        private void annincome_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(currentsalary.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter numbers only.");
                currentsalary.Text = currentsalary.Text.Remove(currentsalary.Text.Length - 1);
            }
        }

        private void retincome_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(retirenestegg.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter numbers only.");
                retirenestegg.Text = retirenestegg.Text.Remove(retirenestegg.Text.Length - 1);
            }
        }

        private void incomeincre_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(incomeincre.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter numbers only.");
                incomeincre.Text = incomeincre.Text.Remove(incomeincre.Text.Length - 1);
            }
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(duringreturnrate.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter numbers only.");
                duringreturnrate.Text = duringreturnrate.Text.Remove(duringreturnrate.Text.Length - 1);
            }
        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(activereturnrate.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter numbers only.");
                activereturnrate.Text = activereturnrate.Text.Remove(activereturnrate.Text.Length - 1);
            }
        }

        private void withdrawal_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(withdrawal.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter numbers only.");
                withdrawal.Text = withdrawal.Text.Remove(withdrawal.Text.Length - 1);
            }
        }
    }
}
