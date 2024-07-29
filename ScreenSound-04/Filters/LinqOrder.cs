using ScreenSound_04.Models;

namespace ScreenSound_04.Filters;

internal class LinqOrder
{
    public static void FilterByName(List<Music> musics)
    {
        var artistsOdained = musics.OrderBy(music => music.Artist).Select(music => music.Artist).Distinct().ToList();

        Console.WriteLine("List of artist odained");
        foreach ( var artist in artistsOdained)
        {
            Console.WriteLine($"-{artist}");
        }
    }

    public static void FilterArtistByMusicalGenre(List<Music> musics, string genre)
    {
        var artistByMusicalGenre = musics.Where(music => music.Genre!.Contains(genre))
            .Select(music => music.Artist).Distinct().ToList();

        Console.WriteLine("Artists by musical genre");
        foreach(var artist in artistByMusicalGenre)
        {
            Console.WriteLine($"-{artist}");
        }
    }
}
