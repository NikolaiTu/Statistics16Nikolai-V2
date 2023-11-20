using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Statistics16Nikolai_V2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //chart1.Series.Add("ListThing");
        }

        private void AverageButton_Click(object sender, EventArgs e)
        {
            List<double> AvgNumbersList = InputBox.Text.Split(' ').Select(double.Parse).ToList();
            double Average = AvgNumbersList.Average();
            AnswerLabel.Text = Average.ToString();
        }

        private void ModeButton_Click(object sender, EventArgs e)
        {
            List<double> ModeNumbersList = InputBox.Text.Split(' ').Select(double.Parse).ToList();
            double Mode = ModeNumbersList.GroupBy(n => n).OrderByDescending(g => g.Count()).Select(g => g.Key).FirstOrDefault();
            AnswerLabel.Text = Mode.ToString();
        }
        
        private void ChartButton_Click(object sender, EventArgs e)
        {
            List<double>NumbersList = InputBox.Text.Split(' ').Select(double.Parse).ToList();
            chart1.Series["ListThing"].Points.Clear();

            foreach (var value in NumbersList)
            { 
                chart1.Series["ListThing"].Points.AddY(value);
            }
        }
    }
}
