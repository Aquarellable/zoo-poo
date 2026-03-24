public class Poule : Animal
{
    public Poule(string nom, Sexe sexe, int age) : base(nom, sexe, age)
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