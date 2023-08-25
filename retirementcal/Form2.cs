using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Net.Mime.MediaTypeNames;

namespace retirementcal
{
    public partial class Form2 : Form
    {
        public static Form2 instance;
        public Label lab;
        public Label lab1;
        public Form2(float[] rvalue)
        {
            InitializeComponent();
            instance = this;
            
            // Input from form1
            lab = label1;                                //name
            lab1 = label29;                              //scenario name
            label2.Text = rvalue[0].ToString();          //current age
            label3.Text = rvalue[1].ToString();          //retirement age 
            label4.Text = rvalue[2].ToString();          //current salary
            label5.Text = rvalue[3].ToString();          //current nestegg
            label6.Text = rvalue[4].ToString();          //income towards retirement yearly 
            label7.Text = rvalue[5].ToString();          //increased income 
            label25.Text = rvalue[8].ToString();         //withdrawal amount

            label21.Text = rvalue[7].ToString();         //annual return rate at active year
            label22.Text = rvalue[6].ToString();         //annual return rate at retirement year

            // Years until retirement
            float retireleftyears = rvalue[1] - rvalue[0];
            label24.Text = retireleftyears.ToString();   

            decimal annualrate = Convert.ToDecimal(rvalue[7] / 100);      //average annual rate of return (active year)
            decimal annualrate1 = Convert.ToDecimal(rvalue[6] / 100);     //average annual rate of return (retirement year)
            decimal nestegg = Convert.ToDecimal(rvalue[3]);
            decimal incrementincome = Convert.ToDecimal(rvalue[5] / 100); //increased income rate 

            decimal contribution = Convert.ToDecimal(rvalue[4]);          //current contribution

            // Creating table and adding columns
            DataTable table = new DataTable();
            table.Columns.Add("Age", typeof(float));
            table.Columns.Add("Balance", typeof(decimal));
            table.Columns.Add("Contribution", typeof(decimal));
            table.Columns.Add("Interest", typeof(decimal));
            table.Columns.Add("Withdrawal", typeof(decimal));

            // Creating chart
            chart1.DataSource = table; //Getting data from the datatable
            chart1.Series.Clear();

            // Add blue line
            chart1.Series.Add("Savings for Retirement");
            chart1.Series[0].XValueMember = "Age";
            chart1.Series[0].YValueMembers = "Balance";
            chart1.Series[0].ChartType = SeriesChartType.Line;

            // Add orange line
            chart1.Series.Add("Withdrawals during Retirement");
            chart1.Series[1].XValueMember = "Age";
            chart1.Series[1].YValueMembers = "Withdrawal";
            chart1.Series[1].ChartType = SeriesChartType.Line;

            chart1.ChartAreas[0].AxisX.Interval = 5;

            // Styling chart
            var title = chart1.Titles.Add("Retirement Savings and Withdrawals");
            title.Font = new System.Drawing.Font("Serif", 18, System.Drawing.FontStyle.Bold);
            title.ForeColor = System.Drawing.Color.Black;

            // Set the title of the X axis
            chart1.ChartAreas[0].AxisX.Title = "Age";
            chart1.ChartAreas[0].AxisX.TitleFont = new System.Drawing.Font("Serif", 12, System.Drawing.FontStyle.Regular);

            // Set the title of the Y axis
            chart1.ChartAreas[0].AxisY.Title = "Balance";
            chart1.ChartAreas[0].AxisY.TitleFont = new System.Drawing.Font("Serif", 12, System.Drawing.FontStyle.Regular);

            // For X axis and Y axis
            chart1.ChartAreas[0].BackColor = Color.White;
            chart1.ChartAreas[0].AxisX.LineColor = Color.Black;
            chart1.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.Black;
            chart1.ChartAreas[0].AxisY.LineColor = Color.Black;
            chart1.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.Black;

            // For grid
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;

            // For plot line
            chart1.Series[0].Color = Color.Blue;
            chart1.Series[0].BorderWidth = 2;
            chart1.Series[1].Color = Color.Orange;
            chart1.Series[1].BorderWidth = 2;

            // Legend
            chart1.Legends[0].Docking = Docking.Bottom;
            chart1.Legends[0].Font = new Font("Serif", 11);


            for (float i = rvalue[0]; i <= 100; i++)
            {
                if (i == rvalue[0])
                {
                    contribution = Convert.ToDecimal(rvalue[4]);
                }
                else
                {
                    // Calculate yearly contribution
                    contribution += incrementincome * contribution;
                }

                // Calculate yearly interest
                decimal interest = nestegg * annualrate;

                // Calculate the yearly withdrawal for retirement years
                decimal yearlywithdrawalpassive = 0;
                if (i >= rvalue[1] - 1)
                {
                    yearlywithdrawalpassive = Convert.ToDecimal(rvalue[8]);
                    contribution = 0;
                    interest = nestegg * annualrate1;
                }

                decimal x = nestegg + interest; //Sum of balance and interest

                // Update nest egg for next year
                if (yearlywithdrawalpassive > x)
                {
                    yearlywithdrawalpassive = x;
                    nestegg += contribution + interest - yearlywithdrawalpassive;
                }
                else
                {
                    nestegg += contribution + interest - yearlywithdrawalpassive;
                }

                // Adding rows to the table
                if (nestegg < 0)
                {
                    table.Rows.Add(i + 1, 0, Decimal.ToInt64(contribution), Decimal.ToInt64(interest), 0);
                }
                else
                {
                    table.Rows.Add(i + 1, Decimal.ToInt64(nestegg), Decimal.ToInt64(contribution), Decimal.ToInt64(interest), Decimal.ToInt64(yearlywithdrawalpassive));
                }

                // Adding data to dataGridView
                dataGridView1.DataSource = table;

                label28.Text = Decimal.ToInt64(nestegg).ToString();
            }
        } 
        private void Form2_Load(object sender, EventArgs e)
        {   

        }

    }
}