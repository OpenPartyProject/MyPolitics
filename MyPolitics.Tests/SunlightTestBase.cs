using MyPolitics.Sunlight.CongressApi;
using RestSharp;

namespace MyPolitics.Tests
{
    internal abstract class SunlightTestBase
    {
        protected readonly IRestClient TestClient = new RestClient("https://congress.api.sunlightfoundation.com/");
        protected readonly IApiKeyProvider TestApiKeyProvider = new EnvironmentVariableApiKeyProvider("SUNLIGHT_API_KEY");
    }
}