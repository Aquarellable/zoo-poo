public class Poule : Animal
{
    public Poule(string nom, int age, Sexe sexe) : base(nom, age, sexe)
    {
        TypeNourriture = Nourriture.Graines;

        if (sexe == Sexe.Male)
        {
            NourritureParJour = 0.18; // coq
            JoursAvantFaim = 2;
        }
        else
        {
            NourritureParJour = 0.15; // poule
            JoursAvantFaim = 1;
        }
    }
}