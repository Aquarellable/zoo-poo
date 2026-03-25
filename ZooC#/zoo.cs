public class Zoo
{
    public double Budget { get; set; }
    public Stockage Stock { get; set; }
    public List<Habitat> Habitats { get; set; }

    public GameData Data { get; set; }

    public Zoo(double budget, Stockage stock, GameData data)
    {
        Data = data;
        Budget = budget;
        Stock = stock;
        Habitats = new List<Habitat>();
    }
}