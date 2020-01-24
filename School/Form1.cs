using SchoolLogic;
using System;
using System.Windows.Forms;

namespace School
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            double math1 = double.Parse(this.txtMathGrade1.Text);
            double math2 = double.Parse(this.txtMathGrade2.Text);
            double math3 = double.Parse(this.txtMathGrade3.Text);
            double[] mathGrades = new double[3];
            mathGrades[0] = math1;
            mathGrades[1] = math2;
            mathGrades[2] = math3;

            SchoolSubject math = new SchoolSubject
            {
                Name = "Mathe",
                Grades = mathGrades,
            };
            double mathAverage = math.CalculateAverage();
            this.lblMathGrade.Text = string.Format("{0:0.00}", mathAverage);

            double german1 = double.Parse(this.txtGermanGrade1.Text);
            double german2 = double.Parse(this.txtGermanGrade2.Text);
            double german3 = double.Parse(this.txtGermanGrade3.Text);
            double[] germanGrades = new double[3];
            germanGrades[0] = german1;
            germanGrades[1] = german2;
            germanGrades[2] = german3;

            SchoolSubject german = new SchoolSubject
            {
                Name = "Deutsch",
                Grades = germanGrades,
            };
            double germanAverage = german.CalculateAverage();
            this.lblGermanGrade.Text = string.Format("{0:0.00}", germanAverage);

        }
    }
}
