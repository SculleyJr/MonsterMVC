using MonsterMVC.Domain.DomainModel;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Configuration;
using System.Threading.Tasks;

namespace MonsterMVC.Clients
{
    public class MonsterClient
    {
        private readonly IRestClient _client;
        public MonsterClient()
        {
            _client = new RestClient(ConfigurationManager.AppSettings["Dnd5eapiBaseUrl"]);
        }
        public async Task<Monster> GetMonster(int id)
        {
            var request = new RestRequest("/monsters/{id}", Method.GET);
            request.AddUrlSegment("id", id);

            try
            {
                var response = await _client.ExecuteTaskAsync(request);
                return JsonConvert.DeserializeObject<Monster>(response.Content);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

    }
}