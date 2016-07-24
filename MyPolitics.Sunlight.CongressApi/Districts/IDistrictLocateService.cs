using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPolitics.CongressApi.Districts
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
