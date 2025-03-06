namespace Core.Client.Services;

using System.Net.Http;
using System.Net.Http.Json;
using System.Web;

public class ApiClient
{
    private readonly HttpClient _httpClient;

    public ApiClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<TResponse?> GetAsync<TRequest, TResponse>(string endpoint, TRequest request)
    {
        var query = ToQueryString(request);
        return await _httpClient.GetFromJsonAsync<TResponse>($"{endpoint}?{query}");
    }

    public async Task<TResponse?> PostAsync<TRequest, TResponse>(string endpoint, TRequest request)
    {
        var response = await _httpClient.PostAsJsonAsync(endpoint, request);
        return await response.Content.ReadFromJsonAsync<TResponse>();
    }

    private static string ToQueryString<T>(T obj)
    {
        if (obj == null)
            return string.Empty;

        var properties = from p in obj.GetType().GetProperties()
                         where p.GetValue(obj, null) != null
                         select $"{HttpUtility.UrlEncode(p.Name)}={HttpUtility.UrlEncode(p.GetValue(obj)!.ToString())}";

        return string.Join("&", properties);
    }
}
