namespace ScreenSound_04.Models;
using System.Text.Json;

internal class FavoriteMusics
{
    public string? Name { get; set; }
    public List<Music> FavoriteMusicsList { get; }

    public FavoriteMusics(string name) 
    {
        Name = name;
        FavoriteMusicsList = new();
    }

    public void AddFavoriteMusic(Music music)
    {
        FavoriteMusicsList.Add(music);
    }

    public void ShowFavoriteMusics()
    {
        Console.WriteLine("Your favorite musics:\n");
        foreach(var music in FavoriteMusicsList)
        {
            Console.WriteLine($"-{music.Name} from {music.Artist}");
        }
    }

    public void GenereateJsonFile()
    {
        string json = JsonSerializer.Serialize(new
        {
            name = Name,
            musics = FavoriteMusicsList
        });
        string fileName = $"favorite-musics-{Name}.json";

        File.WriteAllText(fileName, json);
        Console.WriteLine($"The JSON file has been created! {Path.GetFullPath(fileName)}");
    }
}
