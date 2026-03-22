decimal budget = 80000;

void AchatAnimal(decimal prixAnimal)
{
    budget = budget - prixAnimal;
    Console.WriteLine( budget );
}

void Achatviande(decimal prixViande)
{
    budget = budget - prixViande; 
    Console.WriteLine(budget);
}

void Achatgraine(decimal prixGraine)
{
    budget = budget - prixGraine;
    Console.WriteLine(budget);
}

void VenteAnimal(decimal prixventeAnimal)
{
    budget = budget + prixventeAnimal;
    Console.WriteLine( budget );
}

void subventionAnnuelle(decimal subvention, int animal)
{
    budget = budget + subvention * animal;
    Console.WriteLine(budget);
}