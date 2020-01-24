using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLogic
{
    public class SchoolSubject
    {
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
            double result = this.Grades[0] + this.Grades[1] + this.Grades[2];
            result = result / 3;
            return result;
        }
    }
}
