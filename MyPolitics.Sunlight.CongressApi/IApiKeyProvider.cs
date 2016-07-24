using System.Threading.Tasks;

namespace MyPolitics.Sunlight.CongressApi
{
    public interface IApiKeyProvider
    {
        Task<string> GetApiKey();
    }
}
