using Newtonsoft.Json;

namespace ApiInterview.Model
{
    public class Task
    {
        public Task(string id, string operation, long left, long right)
        {
            Id = id;
            Operation = operation;
            Left = left;
            Right = right;
        }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("operation")]
        public string Operation { get; set; }
        [JsonProperty("left")]
        public long Left { get; set; }
        [JsonProperty("right")]
        public long Right { get; set; }
    }
}
