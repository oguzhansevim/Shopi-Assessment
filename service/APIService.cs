using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Shopi.service
{
    class APIService
    {
        String apiUrl = "https://dev.shopiconnect.com/api/productImport/ImportDeltaProducts";

        public APIService(String jsonData)
        {
            Task.Run(() => this.PostData(apiUrl, jsonData)).Wait();
        }

        async Task PostData(String url, String jsonData)
        {
            try
            {
                HttpClient httpClient = new HttpClient();
                var response = await httpClient.PostAsync(url, new StringContent(jsonData, Encoding.UTF8, "application/json"));

                if (response.IsSuccessStatusCode) Console.WriteLine("Post Request has been successfully ended.");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
