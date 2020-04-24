using SchoolData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLogic
{
    /// <summary>
    /// SchoolSubject.
    /// </summary>
    public class SchoolSubject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SchoolSubject"/> class.
        /// </summary>
        public SchoolSubject()
        {
        }

        public void Save()
        {
            DataAccess dataAccess = new DataAccess();
            dataAccess.SaveData(this.ToString());
        }

        /// <summary>
        /// Gets or sets the grades.
        /// </summary>
        /// <value>
        /// The grades.
        /// </value>
        public double[] Grades { get; set; }

        /// <summary>
        /// Gets or sets the average.
        /// </summary>
        /// <value>
        /// The average.
        /// </value>
        public double Average
        {
            get
            {
                if (double.IsNaN(this.average))
                {
                    var calculated = this.CalculateAverage();
                    this.average = calculated;
                }
                return this.average;
            }
        }
        private double average = double.NaN;

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Calculates the average.
        /// </summary>
        /// <returns></returns>
        public double CalculateAverage()
        {
            double result = 0;

            if (this.Grades == null)
            {
                return result;
            }

            List<double> grades = this.Grades.ToList<double>();

            int gradeCount = 0;

            foreach (double grade in grades)
            {
                if (grade != 0 && !double.IsNaN(grade))
                {
                    result += grade;
                    gradeCount++;
                }
            }
            if (gradeCount != 0)
            {
                result /= gradeCount;
            }
            this.average = result;
            return this.Average;
        }

        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(this.Name);
            stringBuilder.Append(",");
            stringBuilder.Append(string.Join(",", this.Grades));
            stringBuilder.Append(",'");
            stringBuilder.Append(this.average);
            stringBuilder.Append("'");
            return stringBuilder.ToString();
        }
    }
}
