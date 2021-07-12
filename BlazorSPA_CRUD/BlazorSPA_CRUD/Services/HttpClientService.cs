//using BlazorSPA_CRUD.Models;
//using BlazorSPA_CRUD.Services;
//using Microsoft.Extensions.Logging;
//using Microsoft.Extensions.Options;
//using Newtonsoft.Json;
//using System.Net;
//using System.Net.Http;
//using System.Threading.Tasks;

//namespace CCM_UI.Ambassador.HttpClientService
//{
//    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
//    public class HttpClientService : IHttpClientService
//    {
//        private readonly string BaseURL;
//        private readonly string MediaType;
//        ILogger<HttpClientService> _logger;

//        public HttpClientService(IOptions<ConfigurationModel.API> apiConfig, ILogger<HttpClientService> logger)
//        {
//            BaseURL = apiConfig.Value.BaseUrl;
//            MediaType = apiConfig.Value.StringContentMediaType;
//            _logger = logger;
//        }
//        #region Public Method
//        /// <summary>
//        /// Method to have a post call using http client
//        /// </summary>
//        /// <param name="url">Url</param>
//        /// <param name="data">Data</param>
//        /// <returns>Http response message</returns>
//        public async Task<HttpResponseMessage> PostAsyncCall(string url, dynamic data)
//        {
//            string json = JsonConvert.SerializeObject(data, Formatting.Indented);
//            using (var stringContent = new StringContent(json, System.Text.Encoding.UTF8, MediaType))
//            {
//                using (HttpClient client = new HttpClient())
//                {
//                    try
//                    {
//                        HttpResponseMessage response = await client.PostAsync(string.Concat(BaseURL, url), stringContent);
//                        string responseBody = await response.Content.ReadAsStringAsync();
//                        return new HttpResponseMessage()
//                        {
//                            Content = new StringContent(responseBody),
//                            StatusCode = response.StatusCode
//                        };
//                    }
//                    catch (HttpRequestException e)
//                    {
//                        _logger.LogError("Exception Details {0}", e);

//                        return new HttpResponseMessage()
//                        {
//                            Content = new StringContent(e.Message),
//                            StatusCode = HttpStatusCode.InternalServerError
//                        };
//                    }
//                }
//            }
//        }
//        public async Task<HttpResponseMessage> GetAsyncCall(string url)
//        {
//            using (HttpClient client = new HttpClient())
//            {
//                try
//                {
//                    HttpResponseMessage response = await client.GetAsync(string.Concat(BaseURL, url)).ConfigureAwait(true);
//                    string responseBody = await response.Content.ReadAsStringAsync();
//                    return new HttpResponseMessage()
//                    {
//                        Content = new StringContent(responseBody),
//                        StatusCode = response.StatusCode
//                    };
//                }
//                catch (HttpRequestException e)
//                {
//                    _logger.LogError("Exception Details {0}", e);
//                    return new HttpResponseMessage()
//                    {
//                        Content = new StringContent(e.Message),
//                        StatusCode = HttpStatusCode.InternalServerError
//                    };
//                }
//            }
//        }
//        #endregion
//    }
//}

