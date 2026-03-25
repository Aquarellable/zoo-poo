using System.Text.Json;

class Data
{
    static void Main()
    {
        string json = File.ReadAllText("db.json");
        var data = JsonSerializer.Deserialize<GameData>(json);
    }
}