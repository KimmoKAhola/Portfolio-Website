using System.Text.Json;
using Project_2.Infrastructure;
using Project_2.Models.ViewModels.GithubProjects;

namespace Project_2.Services;

public class GithubApiService(HttpClient httpClient) : IGithubProjectService
{
    private readonly JsonSerializerOptions _jsonOptions =
        new() { PropertyNameCaseInsensitive = true };

    public async Task<List<GithubProjectModel>> Get()
    {
        var httpResponse = await httpClient.GetAsync("Project");
        try
        {
            httpResponse.EnsureSuccessStatusCode();
            var content = await httpResponse.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<List<GithubProjectModel>>(
                content,
                _jsonOptions
            );
            return result;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
