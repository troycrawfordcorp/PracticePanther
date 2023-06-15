

public class Program
{
    private static ClientManager clientManager;
    private static ProjectManager projectManager;

    public static void Main()
    {
        clientManager = new ClientManager();
        projectManager = new ProjectManager(clientManager);

        bool running = true;

        while (running)
        {
            DisplayMenu(out running);
        }

        Console.WriteLine("Quitting program. Thank you");
    }

    public static void DisplayMenu(out bool running)
    {
        Console.WriteLine("---C: Create a Client---");
        Console.WriteLine("---R: Display a Client---");
        Console.WriteLine("---U: Update a Client---");
        Console.WriteLine("---D: Delete a Client---");
        Console.WriteLine("---P: Create a Project---");
        Console.WriteLine("---Q: Quit---");
        Console.WriteLine("-----Enter choice---------");
        Console.WriteLine();
        string choice = Console.ReadLine()?.ToUpper();

        running = true;

        switch (choice)
        {
            case "C":
                CreateClient();
                break;
            case "R":
                DisplayClient();
                break;
            case "U":
                UpdateClient();
                break;
            case "D":
                DeleteClient();
                break;
            case "P":
                CreateProject();
                break;
            case "Q":
                running = false;
                break;
            default:
                Console.WriteLine("Invalid Entry");
                break;
        }
    }

    public static void CreateClient()
    {
        Console.WriteLine("Enter client details:");
        Console.Write("Id: ");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Active?:");
        var IsActive = Console.ReadLine();
        Console.WriteLine("notes:");
        var Notes = Console.ReadLine();


        clientManager.CreateClient(id, name);
        Console.WriteLine("Client added successfully!");
    }

    public static void DisplayClient()
    {
        Console.Write("Enter the client Id to display: ");
        int clientId = Convert.ToInt32(Console.ReadLine());

        Client client = clientManager.GetClientById(clientId);
        if (client != null)
        {
            Console.WriteLine($"Id: {client.ID}");
            Console.WriteLine($"Name: {client.Name}");
            Console.WriteLine("Projects:");

            foreach (Project project in client.Projects)
            {
                Console.WriteLine($"- Id: {project.Id}");
                Console.WriteLine($"  Short Name: {project.ShortName}");
                Console.WriteLine($"  Long Name: {project.LongName}");
                Console.WriteLine($"  Open Date: {project.OpenDate}");
                Console.WriteLine($"  Closed Date: {project.ClosedDate}");
                Console.WriteLine($"  Is Active: {project.IsActive}");
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Client not found.");
        }
    }
    public static void UpdateClient()
    {
        Console.Write("Enter the client Id to update: ");
        int clientId = Convert.ToInt32(Console.ReadLine());

        Client client = clientManager.GetClientById(clientId);
        if (client != null)
        {
            Console.Write("New Name: ");
            string newName = Console.ReadLine();
            client.Name = newName;

            Console.WriteLine("Client updated successfully!");
        }
        else
        {
            Console.WriteLine("Client not found.");
        }
    }

    public static void DeleteClient()
    {
        Console.Write("Enter the client Id to delete: ");
        int clientId = Convert.ToInt32(Console.ReadLine());

        clientManager.DeleteClient(clientId);
        Console.WriteLine("Client deleted successfully!");
    }

    public static void CreateProject()
    {
        Console.WriteLine("Enter project details:");
        Console.Write("Id: ");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.Write("Short Name: ");
        string shortName = Console.ReadLine();
        Console.Write("Long Name: ");
        string longName = Console.ReadLine();
        Console.Write("Open Date: ");
        DateTime openDate = DateTime.Parse(Console.ReadLine());
        Console.Write("Closed Date: ");
        DateTime closedDate = DateTime.Parse(Console.ReadLine());
        Console.Write("Is Active (true/false): ");
        bool isActive = Convert.ToBoolean(Console.ReadLine());
        Console.Write("Client Id: ");
        int clientId = Convert.ToInt32(Console.ReadLine());

        projectManager.CreateProject(id, shortName, longName, openDate, closedDate, isActive, clientId);
        Console.WriteLine("Project added successfully!");
    }
}
