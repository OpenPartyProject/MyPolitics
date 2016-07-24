using System.Threading.Tasks;

namespace MyPolitics.CongressApi.Legislators
{
    public interface ILegislatorSearchService
    {
        //todo: implement ILegislatorSearchService
        //todo: document ILegislatorSearchService
        Task<LegislatorSearchResult> SearchBy(LegislatorSearchOptions options);
    }
}