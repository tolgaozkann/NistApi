using NistApi.Request.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace NistApi.Request
{
    public class NistApiService : INistApiService
    {
        public async Task<Root> Get(string URL)
        {
            using (var client = new HttpClient())//aoutomaticly closes the connection
            {
                try
                {
                    Console.WriteLine("Requesting....................");
                    var endpoint = new Uri(URL);//API URI
                    var result = client.GetAsync(endpoint).Result;//HttpResponseMessage
                    var json = result.Content.ReadAsStringAsync().Result;//json as a string
                    Console.WriteLine("Success.......................");
                    var model = JsonSerializer.Deserialize<Root>(json);
                    return model;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
        }
    }
}
