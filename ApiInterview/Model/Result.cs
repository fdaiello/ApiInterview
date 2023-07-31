using Newtonsoft.Json;

namespace ApiInterview.Model
{
    public class Result
    {
        public Result (string id, long value)
        {
            Id = id;
            Value = value;

        }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("result")]
        public long Value { get; set; }
    }
}
