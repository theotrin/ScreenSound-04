using ScreenSound_04.Models;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string response = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        // Console.WriteLine(response);

        var musics = JsonSerializer.Deserialize<List<Music>>(response)!;
        musics[4].ShowMusicDetails();
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
