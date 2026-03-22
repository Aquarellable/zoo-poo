public class Zoo
{
    public double Budget { get; set; }
    public Stockage Stock { get; set; }
    public List<Habitat> Habitats { get; set; }

    public Zoo(double budget, Stockage stock)
    {
        Budget = budget;
        Stock = stock;
        Habitats = new List<Habitat>();
    }

    public void AcheterHabitat(string typeAnimal, int prix)
    {
        if (Budget >= prix)
        {
            Habitats.Add(new Habitat(typeAnimal, 5));
            Budget -= prix;
            Console.WriteLine($"Habitat pour {typeAnimal} acheté !");
        }
        else
        {
            Console.WriteLine("Pas assez de budget.");
        }
    }
}