public class Animal
{
    public string Nom { get; set; }
    public int Age { get; set; }

    public Animal(string nom, int age)
    {
        Nom = nom;
        Age = age;
    }

    public void SePresenter()
    {
        Console.WriteLine($"Je suis {Nom} et j'ai {Age} ans.");
    }
}