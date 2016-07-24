using System.Threading.Tasks;
using MyPolitics.Sunlight.CongressApi.Legislators;
using NUnit.Framework;

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

        [Test]
        public async Task LocateBy_VillageCoffeeShop_Returns()
        {
            var sut = new SunlightLegislatorLocateService(TestClient, TestApiKeyProvider);
            var result = await sut.LocateBy(new LegislatorsLocateOptions
            {
                Latitude = 40.015600,
                Longitude = -105.263467,
            });

            Assert.That(result?.Results, Has.Length.GreaterThan(1));
        }
    }
}
