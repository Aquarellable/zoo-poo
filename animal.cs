public enum Nourriture
{
    Viande,
    Graines
}

public enum Sexe
{
    Male,
    Femelle
}
public class Animal
{
    public string Nom { get; set; }
    public Sexe Sexe { get; set; }
    public int Age { get; set; }

    public int PrixAchat { get; set; }
    public int PrixVente { get; set; }
    public Nourriture TypeNourriture { get; set; }
    public double NourritureParJour { get; set; }
    public int JoursAvantFaim { get; set; }

    public Animal(string nom, Sexe sexe, int age)
    {
        Nom = nom;
        Sexe = sexe;
        Age = age;
    }
}