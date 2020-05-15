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

namespace SchoolFunction
{
    public static class Calculator
    {
        [FunctionName("Calculator")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            SchoolSubject data = JsonConvert.DeserializeObject<SchoolSubject>(requestBody);

            string responseMessage = JsonConvert.SerializeObject(data);

            req.HttpContext.Response.Headers.Add("Content-Type", "application/json");
            return new OkObjectResult(JObject.Parse(responseMessage));
        }
    }
}
