using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace CRM_Nenne_Orders_Api
{
    public class ApiClient
    {
        private readonly HttpClient httpClient = new HttpClient();

        public async Task<bool> VerifyCustomer(int id)
        {
            
            var response = await GetCustomer(id.ToString());

            if(string.IsNullOrEmpty(response))
            {
                return false;
            }
            return true;
        }
        private async Task<string> GetCustomer(string id)
        {
            string url = "https://localhost:44320/api/Customers/" + id;
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            var stringTask = httpClient.GetStringAsync(url);

            return await stringTask;
        }

    }
}
