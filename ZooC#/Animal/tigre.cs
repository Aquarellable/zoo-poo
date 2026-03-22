public class Tigre : Animal
{
    public Tigre(string nom, Sexe sexe) : base(nom, sexe)
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