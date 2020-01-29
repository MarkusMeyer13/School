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
            for(int i= 0; i < this.Grades.Length; i++)
            {
                result += this.Grades[i];
            }
            result /= this.Grades.Length;
            return result;
        }
    }
}
