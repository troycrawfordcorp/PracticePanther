public class ProjectManager
{
    private List<Project> projectList;
    private ClientManager clientManager;

    public ProjectManager(ClientManager clientManager)
    {
        projectList = new List<Project>();
        this.clientManager = clientManager;
    }

    public void CreateProject(int id, string shortName, string longName, DateTime openDate, DateTime closedDate, bool isActive, int clientId)
    {
        Project newProject = new Project(id, shortName, longName, openDate, closedDate, isActive, clientId);
        projectList.Add(newProject);

        // Link the project to the client
        Client client = clientManager.GetClientById(clientId);
        if (client != null)
        {
            client.Projects.Add(newProject);
        }
    }
}