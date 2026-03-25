public class Nid : Habitat
{
    public Nid() : base(5, 300, 220)
    {
    }

    public bool AjouterAigle(Aigle aigle)
    {
        return AjouterAnimal(aigle);
    }
}