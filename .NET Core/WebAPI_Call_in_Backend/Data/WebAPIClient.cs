using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class WebAPIClient
    {
        string APIUrl;
        public HttpClient client;
        public WebAPIClient(string apiUrl, HttpRequest request)
        {
            //send request to api to get user by token that get from url

            this.APIUrl = apiUrl;
            client = new HttpClient { BaseAddress = new Uri(this.APIUrl) };
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            if (request != null)
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", request.Cookies["jwtToken"]);
        }

        public async Task<HttpResponseMessage> PostAsJsonAsync<T>(string requestUri, T value)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync(requestUri, value);
            return response;

        }

        public async Task<HttpResponseMessage> GetAsync(string requestUri)
        {
            HttpResponseMessage response = await client.GetAsync(requestUri);
            return response;
        }

        public async Task<HttpResponseMessage> PostAsync(string requestUri, HttpContent value)
        {
            HttpResponseMessage response = await client.PostAsync(requestUri, value);
            return response;

        }
    }
}
