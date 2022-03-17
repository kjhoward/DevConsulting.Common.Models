using System.Net.Http.Headers;

namespace DevConsulting.Common.Models.Extensions;
public static class HttpClientExtensions
    {
        public static HttpClient AddTokenToHeader(this HttpClient cl, string token)
        {    
            cl.DefaultRequestHeaders.Authorization =
            new AuthenticationHeaderValue("Bearer", token);       
            return cl;
        }
    }