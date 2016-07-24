using System.Threading.Tasks;

namespace MyPolitics.CongressApi.Legislators
{
    public interface ILegislatorLocateService
    {
        Task<LegislatorLocateResult> LocateBy(LegislatorsLocateOptions options);
    }
}