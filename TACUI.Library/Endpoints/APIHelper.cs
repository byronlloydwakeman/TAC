using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using TACUI.Library.Models;

namespace TACUI.Library.Endpoints
{
    public class APIHelper : IAPIHelper
    {
        public HttpClient _apiClient { get; set; }

        private void InitializeClient()
        {
            _apiClient = new HttpClient();
            _apiClient.BaseAddress = new Uri("https://localhost:44304/");
            _apiClient.DefaultRequestHeaders.Accept.Clear();
            _apiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public APIHelper()
        {
            InitializeClient();
        }

        //Login
        public async Task Login(string username, string password)
        {
            var data = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("grant_type", "password"),
                new KeyValuePair<string, string>("username", username),
                new KeyValuePair<string, string>("password", password)
            });

            using (HttpResponseMessage response = await _apiClient.PostAsync("/Token", data))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsAsync<AccessTokenModel>();

                    //Set up authentication for future use
                    _apiClient.DefaultRequestHeaders.Clear();
                    _apiClient.DefaultRequestHeaders.Accept.Clear();
                    _apiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    _apiClient.DefaultRequestHeaders.Add("Authorization", $"Bearer { result.Access_Token }");
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public void Logout()
        {
            //Clear the request headers with the access token, so they can no longer use authorized controllers
            _apiClient.DefaultRequestHeaders.Clear();
        }

        public async Task Register(string email, string password, string confirmPassword)
        {
            var data = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("Email", email),
                new KeyValuePair<string, string>("Password", password),
                new KeyValuePair<string, string>("ConfirmPassword", confirmPassword)
            });

            using (HttpResponseMessage response = await _apiClient.PostAsync("/api/Account/Register", data))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
