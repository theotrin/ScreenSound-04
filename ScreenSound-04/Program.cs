using ScreenSound_04.Models;
using System.Text.Json;
using ScreenSound_04.Filters;
using (HttpClient client = new HttpClient())
{
    try
    {
        string response = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        // Console.WriteLine(response);

        var musics = JsonSerializer.Deserialize<List<Music>>(response)!;
        //LinqFilter.FilterAllGengers(musics);
        //LinqOrder.FilterByName(musics);
        //LinqOrder.FilterArtistByMusicalGenre(musics, "hip hop");
        //LinqFilter.FilterMusicFromArtist(musics, "Post Malone");
        LinqFilter.FilterMusicsByYear(musics);

    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}


//using (HttpClient client = new HttpClient())
//{
//    try
//    {
//        string response = await client.GetStringAsync("https://www.anapioficeandfire.com/api/characters/16");
//        // Console.WriteLine(response);

//        var character = JsonSerializer.Deserialize<Character>(response)!;
//        character.ShowCharacter();
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine(ex.Message);
//    }
//}
