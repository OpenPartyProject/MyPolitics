using System.Threading.Tasks;

namespace MyPolitics.Sunlight.CongressApi
{
    public class StringApiKeyProvider : IApiKeyProvider
    {
        private readonly string _apiKey;

        public StringApiKeyProvider(string apiKey)
        {
            _apiKey = apiKey;
        }

        public Task<string> GetApiKey()
        {
            return Task.FromResult(_apiKey);
        }
    }
}