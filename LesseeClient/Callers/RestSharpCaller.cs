using System.Collections.Generic;
using System.Net;
using LesseeClient.Models;
using RestSharp;

namespace LesseeClient.Caller.Callers
{
    public class RestSharpCaller : ICaller
    {
        private RestClient client;
        public RestSharpCaller(string baseUrl)
        {
            client = new RestClient(baseUrl);
        }

        public List<Platform> GetPlatforms()
        {
            var request = new RestRequest("platforms", Method.GET);
            var response = client.Execute<List<Platform>>(request);
            return response.Data;
        }

        public List<Hardware> GetHardwares(string platform)
        {
            var path = "hardwares";
            if (platform != null)
            {
                path = $"{path}?platform={platform}";
            }
            var request = new RestRequest(path, Method.GET);
            var response = client.Execute<List<Hardware>>(request);
            return response.Data;
        }

        public void Create(Hardware hardware)
        {
            var request = new RestRequest("hardwares", Method.POST);
            request.AddJsonBody(hardware);
            client.Execute(request);
        }

        public List<Lease> GetLeases(string active)
        {
            var path = "leases";
            if (active != null)
            {
                path = $"{path}?active={active}";
            }
            var request = new RestRequest(path, Method.GET);
            var response = client.Execute<List<Lease>>(request);
            return response.Data;
        }


    }
}