namespace ConsoleApp19;

class Program
{
    static void Main(string[] args)
    {
        var banquer = new Banquer();
        
        banquer.CrearClient("Frederic");
        
        Console.WriteLine(banquer.PosarDiners("Frederic", 100));
        Console.WriteLine(banquer.TreureDiners("Frederic",200));
        Console.WriteLine(banquer.TreureDiners( "Frederic",10));

    }
}