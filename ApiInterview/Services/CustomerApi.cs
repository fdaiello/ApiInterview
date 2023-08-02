using Newtonsoft.Json;
using System.Net;
using ApiInterview.Model;
using System.Text;

namespace ApiInterview.Services
{
    public class CustomerApi
    {
        private readonly ILogger _logger;
        public CustomerApi(ILogger<CustomerApi> logger)
        {
            _logger = logger;
        }
        public async Task<Model.Task?> GetTaskAsync()
        {
            var uri = "https://interview.adpeai.com/api/v1/get-task";

            using var httpClient = new HttpClient();

            try
            {
                var response = await httpClient.GetAsync(uri);
                if (response != null && response.StatusCode == HttpStatusCode.OK)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    if ( !String.IsNullOrEmpty(result))
                    {
                        var task = JsonConvert.DeserializeObject<Model.Task>(result);
                        return task;
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                _logger.LogError("CustomerApi.GetTAskAsync: {Message}",ex.Message);
                return null;
            }

        }
        public async Task<string> PostResultAsync(ResultDto1 resultDto)
        {
            var uri = "https://interview.adpeai.com/api/v1/submit-task";

            using var httpClient = new HttpClient();
            var content = JsonConvert.SerializeObject(resultDto);
            var data = new StringContent(content, Encoding.UTF8, "application/json");

            try
            {
                var response = await httpClient.PostAsync(uri, data);

                var responseContent = await response.Content.ReadAsStringAsync();
                return responseContent;

            }
            catch (Exception ex)
            {
                _logger.LogError("CustomerApi.GetTAskAsync: {Message}", ex.Message);
                return ex.Message;
            }

        }
        public async Task<string> PostResultAsync(ResultDto2 resultDto)
        {
            var uri = "https://interview.adpeai.com/api/v1/submit-task";

            using var httpClient = new HttpClient();
            var content = JsonConvert.SerializeObject(resultDto);
            var data = new StringContent(content, Encoding.UTF8, "application/json");

            try
            {
                var response = await httpClient.PostAsync(uri, data);

                var responseContent = await response.Content.ReadAsStringAsync();
                return responseContent;

            }
            catch (Exception ex)
            {
                _logger.LogError("CustomerApi.GetTAskAsync: {Message}", ex.Message);
                return ex.Message;
            }

        }

    }
}
