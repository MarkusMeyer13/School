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
            double result = 0;

            if (this.Grades == null)
            {
                return result;
            }

            List<double> grades = this.Grades.ToList<double>();

            int gradeCount = 0;

            foreach (double grade in grades)
            {
                if(grade != 0 && !double.IsNaN(grade))
                {
                    result += grade;
                    gradeCount++;
                }
            }
            if (gradeCount != 0)
            {
                result /= gradeCount;
            }

            return result;
        }
     }
}
