namespace FakeDataGenerator.Model;

public class LogStoreInputModel
{ 
    public  Guid Id { get; set; }
    public string AppName { get; set; }
    public int OrgId { get; set; }
    public string Source { get; set; }
    public IList<LogObjectModel> LogObjects { get; set; }
}