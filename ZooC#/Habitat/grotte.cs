public class Grotte : Habitat
{
    public Grotte() : base(3, 500, 350)
    {
    }

    public bool AjouterTigre(Tigre tigre)
    {
        return AjouterAnimal(tigre);
    }
}