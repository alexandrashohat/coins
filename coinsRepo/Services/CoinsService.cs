using coinsRepo.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace coinsRepo.Services
{
    public class CoinsService
    {
        public HttpClient Client { get; }

        public CoinsService(HttpClient client)
        {
            client.BaseAddress = new Uri("https://min-api.cryptocompare.com");
            Client = client;
        }

        public async Task<Dictionary<string, Data>> FindCoinListAsync()
        {
            using (var stream = await Client.GetStreamAsync($"/data/all/coinlist"))
            using (var streamReader = new StreamReader(stream))
            using (var reader = new JsonTextReader(streamReader))
            {
                var serializer = new JsonSerializer();
                var response = serializer.Deserialize<dynamic>(reader);
                Dictionary<string, Data> dict = new Dictionary<string, Data>();

                Data d = new Data();
                foreach (var item in response.Data)
                {
                    var b = item.Value.ToString();
                    var value = JsonConvert.DeserializeObject<Data>(b);
                    dict.Add(item.Name, value);
                }
                return dict;
            }
        }
    }

}
