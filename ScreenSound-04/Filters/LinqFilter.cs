namespace ScreenSound_04.Filters;

using ScreenSound_04.Models;

internal class LinqFilter
{
    public static void FilterAllGengers(List<Music> musics)
    {
        var AllMusicalGenres = musics.Select(genres => genres.Genre).Distinct().ToList();

        foreach(var genre in AllMusicalGenres)
        {
            Console.WriteLine($"-{genre}");
        }
    }

    public static void FilterMusicFromArtist(List<Music> musics, string artist)
    {
        var allArtistMusics = musics.Where(music => music.Artist!.Equals(artist)).ToList();
        
        Console.WriteLine($"all musics from: {artist}");
        foreach(var music in allArtistMusics)
        {
            Console.WriteLine($"-{music.Name}");
        }
    }

    public static void FilterMusicsByYear(List<Music> musics)
    {
        var musicsByYear = musics.OrderBy(music => music.Year).ToList();

        Console.WriteLine("Songs sorted by year");
        foreach(var music in musicsByYear)
        {
            Console.WriteLine($"({music.Year}) {music.Name}");
        }
    }

    public static void FilterAllTonalities(List<Music> musics)
    {
        var musicalTonalities = musics.Where(music => music.Note!.Equals("C#")).Select(music => music.Name).ToList();

        Console.WriteLine("All C# Tonalities:");
        foreach( var note in musicalTonalities)
        {
            Console.WriteLine(note);
        }
    }
}
