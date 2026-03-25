Console.WriteLine("1 - Afficher les animaux");
Console.WriteLine("2 - Afficher le stock alimentaire");
Console.WriteLine("3 - Magasin ");
Console.WriteLine("4 - Banque");
Console.WriteLine("5- Année suivante");

string choixUtlisateur = Console.ReadLine();

switch (choixUtilisateur)
{
    case "1":
        Console.WriteLine("Affichage animaux");
        break;
    case "2":
        Console.WriteLine("Afficher le stock alimentaire");
        break;
    case "3":
        Console.WriteLine("Magasin");
        break;
    case "4":
        Console.WriteLine("Banque");
        break;
    case "5":
        Console.WriteLine("Année suivante");
        break;
    default:
    Console.WriteLine("erreur");
    break;
}

