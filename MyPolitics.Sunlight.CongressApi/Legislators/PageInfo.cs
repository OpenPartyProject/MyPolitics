using Newtonsoft.Json;

namespace MyPolitics.CongressApi.Legislators
{
    public class PageInfo
    {
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("per_page")]
        public int PerPage { get; set; }
        [JsonProperty("page")]
        public int Page { get;set; }
    }
}