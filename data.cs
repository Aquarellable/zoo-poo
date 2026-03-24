using System;
using System.IO;
using System.Text.Json;

namespace ZooApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "db.json"; // chemin vers ton fichier
            string jsonString = File.ReadAllText(filePath);

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            ZooDatabase db = JsonSerializer.Deserialize<ZooDatabase>(jsonString, options);

            // Test : afficher la nourriture d'un tigre mâle
            var tigerMaleFood = db.Animals["tiger"].Male["tiger"].Food;
            Console.WriteLine($"Le tigre mâle mange : {tigerMaleFood}");
        }
    }
}