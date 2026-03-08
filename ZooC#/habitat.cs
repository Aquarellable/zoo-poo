public class Habitat
{
    public string TypeAnimal { get; set; }
    public int Capacite { get; set; }
    public List<Animal> Animaux { get; set; }

    public Habitat(string typeAnimal, int capacite)
    {
        TypeAnimal = typeAnimal;
        Capacite = capacite;
        Animaux = new List<Animal>();
    }

    public void AjouterAnimal(Animal animal)
    {
        if (Animaux.Count < Capacite)
        {
            Animaux.Add(animal);
            Console.WriteLine($"{animal.Nom} ajouté dans l'habitat {TypeAnimal}");
        }
        else
        {
            Console.WriteLine("Habitat plein !");
        }
    }
}