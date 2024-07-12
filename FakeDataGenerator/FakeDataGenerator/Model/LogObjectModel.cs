namespace FakeDataGenerator.Model;

public class LogObjectModel
{
    public string UserLoginId { get; set; }
    public string Message { get; set; }
    public DateTime TimeGenerated { get; set; }
    public string ServiceName { get; set; }
    public LogPriority Priority { get; set; }
    public LogsLevel LogLevel { get; set; }
    public LogCategory LogCategory { get; set; }
}
public enum LogCategory
{
    Application = 0,
    Audit = 1,
    System = 2,
    Firewall = 3,
    Network = 4,
    Other = 5

}
public enum LogPriority
{

    None = 0,
    Trace = 1,
    InteractionLevel = 2,
    StandardLevel = 3,
    Alarm = 4,

}
public enum LogsLevel
{
    None = 0,
    Trace = 1,
    Debug = 2,
    Warning = 3,
    Error = 4,
    Critical = 5,

}