using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolLogic;

namespace School.Test
{
    /// <summary>
    /// CalculateTests.
    /// </summary>
    [TestClass]
    public class CalculateTests
    {
        /// <summary>
        /// Tests the three grades.
        /// </summary>
        [TestMethod]
        public void TestThreeGrades()
        {
            SchoolSubject math = new SchoolSubject
            {
                Name = "Mathe",
            };
            math.Grades = new double[3];
            math.Grades[0] = 3;
            math.Grades[1] = 2;
            math.Grades[2] = 4;
            var result = math.CalculateAverage();
            Assert.AreEqual(3, result);
        }

        /// <summary>
        /// Tests four grades.
        /// </summary>
        [TestMethod]
        public void TestFourGrades()
        {
            SchoolSubject math = new SchoolSubject
            {
                Name = "Mathe",
            };
            math.Grades = new double[4];
            math.Grades[0] = 3;
            math.Grades[1] = 2;
            math.Grades[2] = 4;
            math.Grades[3] = 3;
            var result = math.CalculateAverage();
            Assert.AreEqual(3, result);
        }


        [TestMethod]
        public void TestThreeGradesBiggerArray()
        {
            SchoolSubject math = new SchoolSubject
            {
                Name = "Mathe",
            };
            math.Grades = new double[4];
            math.Grades[0] = 3;
            math.Grades[1] = 2;
            math.Grades[2] = 4;
            var result = math.CalculateAverage();
            Assert.AreEqual(3, result);
        }


        /// <summary>
        /// Tests the no grades.
        /// </summary>
        [TestMethod]
        public void TestNoGrades()
        {
            SchoolSubject math = new SchoolSubject
            {
                Name = "Mathe",
            };

            var result = math.CalculateAverage();
            Assert.AreEqual(0, result);
        }

        /// <summary>
        /// Tests the empty grades.
        /// </summary>
        [TestMethod]
        public void TestEmptyGrades()
        {
            SchoolSubject math = new SchoolSubject
            {
                Name = "Mathe",
            };
            math.Grades = new double[4];
            var result = math.CalculateAverage();
            Assert.AreEqual(0, result);
        }


        /// <summary>
        /// Tests the three grades double execute.
        /// </summary>
        [TestMethod]
        public void TestThreeGradesDoubleExecute()
        {
            SchoolSubject math = new SchoolSubject
            {
                Name = "Mathe",
            };
            math.Grades = new double[3];
            math.Grades[0] = 3;
            math.Grades[1] = 2;
            math.Grades[2] = 4;
            var result = math.CalculateAverage();
            result = math.CalculateAverage();
            Assert.AreEqual(3, result);
        }
    }
}
