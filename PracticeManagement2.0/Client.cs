public class Client
{
    // properties for constructor//

    public int ID { get; set; }
    public DateTime OpenDate { get; set; }
    public DateTime ClosedDate { get; set; }
    public bool IsActive { get; set; }
    public string Name { get; set; }
    public string? Notes { get; set; }
    public List<Project> Projects { get; set; }

    public Client(int id, string name)
    {
        ID = id;
        Name = name;
        Projects = new List<Project>();
    }
}
