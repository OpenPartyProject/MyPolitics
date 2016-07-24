using System.Threading.Tasks;

namespace MyPolitics.Sunlight.CongressApi.Districts
{
    public interface IDistrictLocateService
    {
        Task<DistrictLocateResult> LocateBy(DistrictLocateOptions options);
    }

    public class DistrictLocateResult
    {
    }

    public class DistrictLocateOptions
    {
        public string ZipCode { get; set; }
    }
}
