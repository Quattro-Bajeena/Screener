namespace Core.Client.Services;

using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Net.Http.Json;
using System.Web;

public class ApiClient
{
    private readonly HttpClient _httpClient;
    private readonly NavigationManager _navigation;

    public ApiClient(HttpClient httpClient, NavigationManager navigation)
    {
        _httpClient = httpClient;
        _navigation = navigation;
    }

    public async Task<TResponse?> GetAsync<TRequest, TResponse>(string endpoint, TRequest request)
    {
        var query = ToQueryString(request);
        Uri url = _navigation.ToAbsoluteUri(endpoint);
        var response = await _httpClient.GetFromJsonAsync<TResponse>($"{url}?{query}");
        return response;
    }

    public async Task<TResponse?> PostAsync<TRequest, TResponse>(string endpoint, TRequest request)
    {
        Uri url = _navigation.ToAbsoluteUri(endpoint);
        var response = await _httpClient.PostAsJsonAsync(url, request);
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
