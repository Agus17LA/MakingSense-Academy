using Phones.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Phones.Helpers
{
    public class APIHelper : IAPIHelper
    {
        private HttpClient apiClient { get; set; }
        public AuthenticatedUser authenticatedUser;
        public APIHelper()
        {
            InitializeClient();
        }

        private void InitializeClient()
        {
            String api = ConfigurationManager.AppSettings["api"];
            apiClient = new HttpClient();
            apiClient.BaseAddress = new Uri(api);
            apiClient.DefaultRequestHeaders.Accept.Clear();
            apiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<AuthenticatedUser> Authenticate(String username, String password)
        {
            var data = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<String,String>("username",username),
                new KeyValuePair<String,String>("password",password)
            });
            using (HttpResponseMessage response = await apiClient.PostAsync("/login/", data))
            {
                if (response.IsSuccessStatusCode)
                {
                    var token = response.Headers.GetValues("Authorization");
                    return new AuthenticatedUser(token.FirstOrDefault(), username);
                }
                else
                    throw new Exception(response.ReasonPhrase);

            }
        }
    }
}
