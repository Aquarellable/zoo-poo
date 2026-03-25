
public class Aigle : Animal
{
    public Aigle(string nom, int age, Sexe sexe, GameData data) : base(nom, age, sexe)
    {
        TypeNourriture = Nourriture.Viande;

        if (sexe == Sexe.Male)
        {
            NourritureParJour = 0;
            JoursAvantFaim = 0;
        }
        else
        {
            NourritureParJour = 0;
            JoursAvantFaim = 0;
        }
    }
}