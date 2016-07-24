using System.Threading.Tasks;

namespace MyPolitics.Sunlight.CongressApi.Legislators
{
    public interface ILegislatorLocateService
    {
        Task<LegislatorLocateResult> LocateBy(LegislatorsLocateOptions options);
    }
}