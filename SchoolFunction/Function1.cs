using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Runtime.CompilerServices;
using System.Dynamic;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace SchoolFunction
{
    public static class Function1
    {
        [FunctionName("Function1")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            string name = req.Query["name"];

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();

            JObject data = JObject.Parse(requestBody);
            var firstName = data["firstname"].Value<string>();
            //var lastName = data["person.lastname"].Value<string>();
            //var lastName = data["person"]["lastname"].Value<string>();
            var lastName = data["persons"][0]["firstname"].Value<string>();

            //JArray persons = data["persons"] as JArray;

            if (data["persons"].Type == JTokenType.Array)
            {
                JArray persons = data["persons"] as JArray;
            }
            if (data["person"].Type == JTokenType.Object)
            {
                data["person"] = null;

                JObject person = data["person"] as JObject;
                if(person != null)
                {
                    Console.WriteLine(person["firstname"]);
                }

                if (data["person"] != null)
                {
                    JObject person1 = (JObject)data["person"];
                    Console.WriteLine(person1["firstname"]);
                }


            }


            //persons.Type == JTokenType.Array;




            //JObject dataConvert = JsonConvert.DeserializeObject<JObject>(requestBody);




            string responseMessage = lastName;


            return new OkObjectResult(responseMessage);
        }

        [FunctionName("Average")]
        public static async Task<IActionResult> Average(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            double number1 = double.NaN;
            if (req.Query.ContainsKey("number1"))
            {
                double.TryParse(req.Query["number1"], out number1);
            }

            double number2 = double.NaN;
            if (req.Query.ContainsKey("number2"))
            {
                double.TryParse(req.Query["number2"], out number2);
            }

            string responseMessage = ((number1 + number2) / 2).ToString();

            return new OkObjectResult(responseMessage);
        }
    }
}
