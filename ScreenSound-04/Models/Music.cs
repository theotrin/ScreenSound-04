using System.Text.Json.Serialization;

namespace ScreenSound_04.Models;

internal class Music
{
    [JsonPropertyName("song")]
    public string? Name { get; set; }
    [JsonPropertyName("artist")]
    public  string? Artist { get; set; }
    [JsonPropertyName("duration")]
    public int Duration { get; set; }
    [JsonPropertyName("genre")]
    public string? Genre { get; set; }
    [JsonPropertyName("year")]
    public string? Year { get; set; }

    public void ShowMusicDetails()
    {
        Console.WriteLine($"Music name: {Name} \nBy: {Artist} \nDuration: {(Duration / 1000) / 60}:00\nGenre: {Genre}");
    }

}
