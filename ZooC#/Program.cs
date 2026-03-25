
{
    static void Main(string[] args)
    {
        Stockage stock = new Stockage(50, 30);
        Zoo zoo = new Zoo(1000, stock);

        Console.WriteLine("Budget du zoo : " + zoo.Budget);
        Console.WriteLine("Stock de graines : " + zoo.Stock.Graines);
        Console.WriteLine("Stock de viande : " + zoo.Stock.Viande);
    }
}
