public enum Sexe
{
    Male,
    Femelle
}

public class Animal
{
    public string Nom { get; set; }
    public int Age { get; set; }
    public Sexe Sexe { get; set; }

    public Animal(string nom, int age, Sexe sexe)
    {
        Nom = nom;
        Age = age;
        Sexe = sexe;
    }

    public void SePresenter()
    {
        Console.WriteLine($"Je suis {Nom}, j'ai {Age} ans et je suis {Sexe}");
    }
}