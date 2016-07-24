using System.Threading.Tasks;
using MyPolitics.Sunlight.CongressApi.Legislators;
using NUnit.Framework;
using RestSharp;

namespace MyPolitics.Tests
{
    internal class SunlightLegislatorLocateServiceTests : SunlightTestBase
    {
        [Test]
        public async Task LocateBy_BoulderZipCode_Returns()
        {
            IRestClient client = new RestClient("https://congress.api.sunlightfoundation.com/");
            var sut = new SunlightLegislatorLocateService(client, TestApiKeyProvider);
            var result = await sut.LocateBy(new LegislatorsLocateOptions
            {
                ZipCode = "80301"
            });

            Assert.That(result?.Results, Has.Length.GreaterThan(1));
        }
    }
}
