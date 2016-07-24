using System.Threading.Tasks;

namespace MyPolitics.CongressApi
{
    public interface IApiKeyProvider
    {
        Task<string> GetApiKey();
    }
}
