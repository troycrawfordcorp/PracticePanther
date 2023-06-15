public class Project
{
    public int Id { get; set; }
    public string ShortName { get; set; }
    public string LongName { get; set; }
    public DateTime OpenDate { get; set; }
    public DateTime ClosedDate { get; set; }
    public bool IsActive { get; set; }
    public int ClientId { get; set; }

    public Project(int id, string shortName, string longName, DateTime openDate, DateTime closedDate, bool isActive, int clientId)
    {
        Id = id;
        ShortName = shortName;
        LongName = longName;
        OpenDate = openDate;
        ClosedDate = closedDate;
        IsActive = isActive;
        ClientId = clientId;
    }
}
