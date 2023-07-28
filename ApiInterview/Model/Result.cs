using Newtonsoft.Json;

namespace ApiInterview.Model
{
    public class Result
    {
        public Result (string id, string taskId, long value)
        {
            Id = id;
            TaskId = taskId;
            Value = value;

        }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("taskId")]
        public string TaskId { get; set; }
        [JsonProperty("result")]
        public long Value { get; set; }
    }
}
