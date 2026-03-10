public class Poulailler : Habitat
{
    public Poulailler() : base(4, 2000, 500)
    {
    }

    public bool AjouterPoule(Poule poule)
    {
        return AjouterAnimal(poule);
    }
}