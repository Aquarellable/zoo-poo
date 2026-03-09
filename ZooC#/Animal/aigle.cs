public class Aigle : Animal
{
    public Aigle(string nom, Sexe sexe) : base(nom, sexe)
    {
        TypeNourriture = Nourriture.Viande;

        if (sexe == Sexe.Male)
        {
            NourritureParJour = 0.25;
            JoursAvantFaim = 10;
        }
        else
        {
            NourritureParJour = 0.3;
            JoursAvantFaim = 10;
        }
    }
}