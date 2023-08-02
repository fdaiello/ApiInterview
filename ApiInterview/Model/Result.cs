using Newtonsoft.Json;
using System.Numerics;

namespace ApiInterview.Model
{
    public class Result
    {
        public Result (string id, string value)
        {
            Id = id;
            Value = value;
        }

        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("result")]
        public string Value { get; set; }
    }
}
