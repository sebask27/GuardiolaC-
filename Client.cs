namespace ConsoleApp19;

public class Client
{

    public Client(string nomClient)
    {
        Nom = nomClient;
        Saldo = 0;

    }
    public string Nom { get; set; }
    
    
    public int Saldo { get; set; }
    
    
}