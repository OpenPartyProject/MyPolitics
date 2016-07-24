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
            var sut = new SunlightLegislatorLocateService(TestClient, TestApiKeyProvider);
            var result = await sut.LocateBy(new LegislatorsLocateOptions
            {
                ZipCode = "80301"
            });

            Assert.That(result?.Results, Has.Length.GreaterThan(1));
        }
    }
}
