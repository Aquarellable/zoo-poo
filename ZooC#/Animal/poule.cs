public class Poule : Animal
{
    public Poule(string nom, int age) : base(nom, age)
    {
    }

    public void Pondre()
    {
        Console.WriteLine($"{Nom} pond un oeuf.");
    }
}