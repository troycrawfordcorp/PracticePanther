public class ClientManager
{
    private List<Client> clientList;

    public ClientManager()
    {
        clientList = new List<Client>();
    }

    public void CreateClient(int id, string name)
    {
        Client newClient = new Client(id, name);
        clientList.Add(newClient);
    }

    public Client GetClientById(int id)
    {
        return clientList.Find(c => c.ID == id);
    }

    public void DeleteClient(int id)
    {
        Client client = clientList.Find(c => c.ID == id);
        if (client != null)
        {
            clientList.Remove(client);
        }
    }
}