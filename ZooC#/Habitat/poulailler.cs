public class Poulailler : Habitat
{
    public Poulailler() : base(10, 200, 150)
    {
    }

    public bool AjouterPoule(Poule poule)
    {
        return AjouterAnimal(poule);
    }
}