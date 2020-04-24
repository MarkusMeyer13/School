using SchoolLogic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace School
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Calculates this instance.
        /// </summary>
        /// <returns></returns>
        private IList<SchoolSubject> Calculate()
        {
            List<SchoolSubject> subjects = new List<SchoolSubject>();

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
            _ = math.CalculateAverage();
            subjects.Add(math);

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
            _ = german.CalculateAverage();
            subjects.Add(german);

            return subjects;
        }

        /// <summary>
        /// Handles the Click event of the BtnCalculate control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            var subjects = this.Calculate();

            for(int i = 0; i < subjects.Count; i++)
            {
                if (subjects[i].Name.Equals("Deutsch"))
                {
                    this.lblGermanGrade.Text = string.Format("{0:0.00}", subjects[i].Average);
                }
                else if (subjects[i].Name.Equals("Mathe"))
                {
                    this.lblMathGrade.Text = string.Format("{0:0.00}", subjects[i].Average);
                }
            }
        }

        /// <summary>
        /// Handles the Click event of the btnSave control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            var subjects = this.Calculate();
            for (int i = 0; i < subjects.Count; i++)
            {
                subjects[i].Save();
            }
        }
    }
}
