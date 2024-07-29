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
}
