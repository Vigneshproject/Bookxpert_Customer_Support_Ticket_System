using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

public class ApiHelper
{
    private static string baseUrl = "https://localhost:5001/api/";

    public static T Post<T>(string url, object data)
    {
        using (HttpClient client = new HttpClient())
        {
            var json = JsonConvert.SerializeObject(data);

            var content = new StringContent(
                json,
                Encoding.UTF8,
                "application/json");

            var res = client
                .PostAsync(baseUrl + url, content)
                .Result;

            var result = res.Content
                .ReadAsStringAsync()
                .Result;

            return JsonConvert.DeserializeObject<T>(result);
        }
    }

    public static T Get<T>(string url)
    {
        using (HttpClient client = new HttpClient())
        {
            var res = client.GetAsync(baseUrl + url).Result;

            var result = res.Content
                .ReadAsStringAsync()
                .Result;

            return JsonConvert.DeserializeObject<T>(result);
        }
    }
}