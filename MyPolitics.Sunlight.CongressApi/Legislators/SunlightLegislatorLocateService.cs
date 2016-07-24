using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;

namespace MyPolitics.Sunlight.CongressApi.Legislators
{
    public class SunlightLegislatorLocateService : ILegislatorLocateService
    {
        private readonly IRestClient _client;
        private readonly IApiKeyProvider _apiKeyProvider;

        public SunlightLegislatorLocateService(IRestClient client, IApiKeyProvider apiKeyProvider)
        {
            _client = client;
            _apiKeyProvider = apiKeyProvider;
        }

        public async Task<LegislatorLocateResult> LocateBy(LegislatorsLocateOptions options)
        {
            var request = new RestRequest("legislators/locate", Method.GET);
            request.AddQueryParameter("apikey", await _apiKeyProvider.GetApiKey());

            if (!string.IsNullOrWhiteSpace(options.ZipCode))
            {
                request.AddQueryParameter("zip", options.ZipCode);
            }
            else if (options.Latitude.HasValue && options.Longitude.HasValue)
            {
                request.AddQueryParameter("latitude", options.Latitude.ToString());
                request.AddQueryParameter("longitude", options.Longitude.ToString());
            }

            var result = await _client.ExecuteTaskAsync(request);
            return JsonConvert.DeserializeObject<LegislatorLocateResult>(result.Content);
        }
    }
}
