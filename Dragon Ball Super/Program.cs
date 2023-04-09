// See https://aka.ms/new-console-template for more information
using Dragon_Ball_Super.Models;
using Newtonsoft.Json;

Console.WriteLine("Hello, World!");
Console.WriteLine();
var data = await GetApiResponse();
 
for (int i = 0; i < data.characters.Count; i++)
{
    Random random = new Random();
    var randomNumber = random.Next(0,data.characters.Count);
    var character = data.characters[randomNumber];
    Console.WriteLine($"Name :" + character.name);
    Console.WriteLine($"Race :" + character.race);
    Console.WriteLine($"Abilities :");
    foreach (string item in character.abilities)
    {
        Console.WriteLine(item);
    }
    Console.WriteLine();
}
//https://dragon-ballz-super-api.site/api

static async Task<ApiResponse> GetApiResponse()
{
    using var httpClient = new HttpClient();
    var response = await httpClient.GetAsync("https://dragon-ballz-super-api.site/api");
    if (response.IsSuccessStatusCode)
    {
        var json = await response.Content.ReadAsStringAsync();
        var responseData = JsonConvert.DeserializeObject<ApiResponse>(json);
        var characters = responseData.characters;
        return responseData;
    }
    else
    {
        return new ApiResponse();
    }
}

