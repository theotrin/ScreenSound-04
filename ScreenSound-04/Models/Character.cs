
using System.Text.Json.Serialization;

namespace ScreenSound_04.Models;

internal class Character
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    [JsonPropertyName("gender")]
    public string? Gender { get; set; }
    [JsonPropertyName("tvSeries")]
    public List<string> Apperances { get; set; }

    public void ShowCharacter()
    {
        Console.WriteLine($"Name: {Name}\nGender: {Gender}");
        Console.WriteLine("\nApperances:\n");
        foreach (var apparence in  Apperances)
        {
            Console.WriteLine(apparence);
        }
    }
}
