public class Tigre : Animal
{
    public Tigre(string nom, int age) : base(nom, age)
    {
    }

    public void Rugir()
    {
        Console.WriteLine($"{Nom} rugit très fort !");
    }
}