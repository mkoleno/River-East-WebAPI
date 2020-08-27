using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace River_East_WebAPI.Controllers
{
    [Route("api/[controller]/{symbol}")]
    [ApiController]
    public class RecommendationTrendsController : ControllerBase
    {
        private static string TOKEN = "bt19fvf48v6qjjkjkn7g";
        [HttpGet]
        public async Task<IEnumerable<RecommendationTrends>> Get(string symbol)
        {
            string requestUrl = String.Format(@"https://finnhub.io/api/v1/stock/recommendation?symbol={0}&token={1}", symbol, TOKEN);

            using (var client = new HttpClient())
            {
                string content = await client.GetStringAsync(requestUrl);
                IEnumerable<RecommendationTrends> returnTarget = null;
                try
                {
                    returnTarget = JsonConvert.DeserializeObject<IEnumerable<RecommendationTrends>>(content);
                }
                catch (JsonException je)
                {
                    Console.WriteLine(je.Message);
                }

                return returnTarget;
            }
        }
    }
}