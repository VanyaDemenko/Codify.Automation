using Newtonsoft.Json;
using RestSharp;
using System.Net;

namespace Codify.Automation.Core.Extensions
{
    public class ApiResponseExtensions
    {
        public HttpStatusCode StatusCode { get; }
        public string? Content { get; private set; }

        public ApiResponseExtensions(RestResponseBase responseMessage)
        {
            StatusCode = responseMessage.StatusCode;
            Content = responseMessage.Content;
        }

        public T GetContent<T>()
        {
            try
            {
                return JsonConvert.DeserializeObject<T>(Content);
            }
            catch (Exception)
            {
                throw new Exception(
                    $"Error deserializing content. StatusCode = {StatusCode} \nContent = {Content}");
            }
        }
    }
}
