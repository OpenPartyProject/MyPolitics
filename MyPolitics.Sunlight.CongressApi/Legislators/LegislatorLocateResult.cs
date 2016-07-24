using Newtonsoft.Json;

namespace MyPolitics.Sunlight.CongressApi.Legislators
{
    public class LegislatorLocateResult
    {
        [JsonProperty("results")]
        public Legislator[] Results { get; set; }
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("page")]
        public PageInfo Page { get; set; }
    }
}