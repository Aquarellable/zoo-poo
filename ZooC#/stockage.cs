public class Stockage
{
    public int Graines { get; set; }
    public int Viande { get; set; }

    public Stockage(int graines, int viande)
    {
        Graines = graines;
        Viande = viande;
    }
}