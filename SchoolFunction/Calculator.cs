using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace SchoolFunction
{
    public static class Calculator
    {
        [FunctionName("Calculator")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            if (req == null)
            {
                return null;
            }


            if (req != null)
            {
                Trace.WriteLine("Start function");

                    StreamReader streamReader = new StreamReader(req.Body);
                    string requestBody = await streamReader.ReadToEndAsync();

                    JObject response = new JObject();
                    JArray responseSchoolSubjects = new JArray();
                response["SchoolSubject"] = responseSchoolSubjects;

                JObject body = JObject.Parse(requestBody);
                if (body.ContainsKey("SchoolSubject"))
                {
                    JArray schoolSubjects = body["SchoolSubject"] as JArray;
                    if (schoolSubjects != null)
                    {
                        var schoolSubjectsEnumerator = schoolSubjects.GetEnumerator();
                        while (schoolSubjectsEnumerator.MoveNext())
                        {
                            JObject schoolSubject = schoolSubjectsEnumerator.Current as JObject;
                            SchoolSubject data = JsonConvert.DeserializeObject<SchoolSubject>(schoolSubject.ToString());
                            var subject = JsonConvert.SerializeObject(data);
                            responseSchoolSubjects.Add(JObject.Parse(subject));
                        }
                    }
                }
                streamReader.Dispose();
                return new OkObjectResult(response);
            }
            return null;
        }




        /// <summary>
        /// Calculates the average school subject math.
        /// </summary>
        /// <param name="req">The req.</param>
        /// <param name="log">The log.</param>
        /// <returns></returns>
        [FunctionName("CalculateAverageSchoolSubjectMath")]
        public static async Task<IActionResult> CalculateAverageSchoolSubjectMath(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            SchoolSubject schoolSubject = new SchoolSubject()
            {
                Name = "Mathe",
            };
            List<double> grades = new List<double>();
            grades.Add(1);
            grades.Add(3);
            grades.Add(4);
            schoolSubject.Grades = grades.ToArray();
            schoolSubject.CalculateAverage();

            var response = new JObject();
            response["test"] = schoolSubject.Average;
            return new OkObjectResult(response);
        }

    }
}
