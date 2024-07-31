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
    [JsonPropertyName("key")]
    public int Key { get; set; }
    public string? Note { get 
                         {
                         return notes[Key];    
                         }}

    Dictionary<int, string> notes = new() 
    {
        {0, "C" },
        {1, "C#" },
        {2, "D" },
        {3, "D#" },
        {4, "E" },
        {5, "F" },
        {6, "F#" },
        {7, "G" },
        {8, "G#" },
        {9, "A" },
        {10, "A#" },
        {11, "B" },
    };


    public void ShowMusicDetails()
    {
        Console.WriteLine($"Music name: {Name}" +
            $"\nBy: {Artist}" +
            $"\nDuration: {(Duration / 1000) / 60}:00" +
            $"\nGenre: {Genre}" +
            $"\nYear: {Year}" +
            $"\nTonality: {Note}");
    }

}
