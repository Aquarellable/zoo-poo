public class Tigre : Animal
{
    public Tigre(string nom, int age, Sexe sexe) : base(nom, age, sexe)
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