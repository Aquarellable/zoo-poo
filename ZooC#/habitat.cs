public abstract class Habitat
{
    public int CapaciteMax { get; set; }
    public int PrixAchat { get; set; }
    public int PrixVente { get; set; }

    public List<Animal> Animaux { get; set; }

    public Habitat(int capacite, int prixAchat, int prixVente)
    {
        CapaciteMax = capacite;
        PrixAchat = prixAchat;
        PrixVente = prixVente;
        Animaux = new List<Animal>();
    }

    public bool AjouterAnimal(Animal animal)
    {
        if (Animaux.Count >= CapaciteMax)
        {
            Console.WriteLine("Habitat plein.");
            return false;
        }

        Animaux.Add(animal);
        return true;
    }
}