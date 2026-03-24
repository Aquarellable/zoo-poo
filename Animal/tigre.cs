public class Tigre : Animal
{
    public Tigre(string nom, Sexe sexe, int age) : base(nom, sexe, age)
    {
        TypeNourriture = Nourriture.Viande;

        if (sexe == Sexe.Male)
        {
            NourritureParJour = 12;
            JoursAvantFaim = 2;
        }
        else
        {
            NourritureParJour = 10;
            JoursAvantFaim = 2;
        }
    }
}