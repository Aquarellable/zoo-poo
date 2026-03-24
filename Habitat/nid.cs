public class Nid : Habitat
{
    public Nid() : base(10, 300, 50)
    {
    }

    public bool AjouterAigle(Aigle aigle)
    {
        return AjouterAnimal(aigle);
    }
}