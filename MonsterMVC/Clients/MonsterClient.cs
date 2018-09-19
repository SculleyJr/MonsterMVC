﻿using MonsterMVC.Domain.DomainModel;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
namespace MonsterMVC.Clients
{
    public class MonsterClient
    {
        private readonly IRestClient _client;
        public MonsterClient()
        {
            _client = new RestClient(ConfigurationManager.AppSettings["Dnd5eapiBaseUrl"]) {Timeout = 500};
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