using MyPolitics.CongressApi;

namespace MyPolitics.Tests
{
    internal abstract class SunlightTestBase
    {
        protected readonly IApiKeyProvider TestApiKeyProvider = new EnvironmentVariableApiKeyProvider("SUNLIGHT_API_KEY");
    }
}