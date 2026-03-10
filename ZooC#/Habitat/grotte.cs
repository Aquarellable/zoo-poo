public class Grotte : Habitat
{
    public Grotte() : base(2, 2000, 500)
    {
    }

    public bool AjouterTigre(Tigre tigre)
    {
        return AjouterAnimal(tigre);
    }
}