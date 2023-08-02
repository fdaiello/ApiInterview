using Newtonsoft.Json;
using System.Numerics;

namespace ApiInterview.Model
{
    public class ResultDto1
    {
        public ResultDto1(Result result)
        {
            Id = result.Id;
            Value = Decimal.Parse(result.Value);
        }

        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("result")]
        public Decimal Value { get; set; }
    }
    public class ResultDto2
    {
        public ResultDto2(Result result)
        {
            Id = result.Id;
            Value = BigInteger.Parse(result.Value);
        }

        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("result")]
        public BigInteger Value { get; set; }
    }

}
