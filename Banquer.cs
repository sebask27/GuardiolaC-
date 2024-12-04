namespace ConsoleApp19;

public class Banquer
{
    private Dictionary<string, Client> clients;

    public Banquer()
    {
        clients = new Dictionary<string, Client>();
    }

    public void CrearClient(string nomNouClient)
    {
        clients.Add(nomNouClient, new Client(nomNouClient));
    }
    
    
    public string PosarDiners(string nomClient, int quantitat)
    {
        if (clients.ContainsKey(nomClient))
        {
            var client = clients[nomClient];
            client.Saldo += quantitat;
            return $"{quantitat} euros ingresats correctament";
        }
        return $"Tu no ets client {nomClient}";
    }

    public string TreureDiners(string nomClient, int quantitat)
    {
        if (clients.ContainsKey(nomClient))
        {
            var client = clients[nomClient];
            var comissio = quantitat / 100;
            if (quantitat + comissio > client.Saldo)
            {
                return $"No tens {quantitat+comissio} ouros prou diners";
            }
            client.Saldo -= quantitat + comissio;
            return $"Té {quantitat} euros et queden {client.Saldo}";
        }
        return $"Tu no ets client {nomClient}";
    }
    
}