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

        /// <summary>
        /// Gets or sets the grades.
        /// </summary>
        /// <value>
        /// The grades.
        /// </value>
        public double[] Grades { get; set; }

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
            List<double> grades = this.Grades.ToList<double>();

            double result = 0;
            //int gradeCount = 0;
            //if (this.Grades != null)
            //{
            //    for (int i = 0; i < this.Grades.Length; i++)
            //    {
            //        if (this.Grades[i] != 0 && this.Grades[i] != double.NaN)
            //        {
            //            result += this.Grades[i];
            //            gradeCount++;
            //        }
            //    }
            //    if (gradeCount != 0)
            //    {
            //        result /= gradeCount;
            //    }
            //}
            return result;
        }
    }
}
