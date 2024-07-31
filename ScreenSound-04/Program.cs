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
        //musics[1].ShowMusicDetails();
        //LinqFilter.FilterAllGengers(musics);
        //LinqOrder.FilterByName(musics);
        //LinqOrder.FilterArtistByMusicalGenre(musics, "hip hop");
        //LinqFilter.FilterMusicFromArtist(musics, "Post Malone");
        //LinqFilter.FilterMusicsByYear(musics);
        LinqFilter.FilterAllTonalities(musics);
        //FavoriteMusics theoFavoriteMusics = new("Theo");
        //theoFavoriteMusics.AddFavoriteMusic(musics[1]);
        //theoFavoriteMusics.AddFavoriteMusic(musics[90]);
        //theoFavoriteMusics.AddFavoriteMusic(musics[44]);
        //theoFavoriteMusics.AddFavoriteMusic(musics[4]);
        //theoFavoriteMusics.AddFavoriteMusic(musics[7]);

        //theoFavoriteMusics.ShowFavoriteMusics();
        //theoFavoriteMusics.GenereateJsonFile();


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
