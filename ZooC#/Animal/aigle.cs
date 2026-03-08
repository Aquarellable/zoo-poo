public class Aigle : Animal
{
    public Aigle(string nom, int age) : base(nom, age)
    {
    }

    public void Voler()
    {
        Console.WriteLine($"{Nom} vole dans le ciel.");
    }
}