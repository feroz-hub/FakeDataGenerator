using Newtonsoft.Json;
using Bogus;
using FakeDataGenerator.Model;

// Your classes here...
class Program
{
    private static void Main(string[] args)
    {
        var faker = new Faker();
        for (var x = 0; x < 10; x++)
        {
            var logStoreInput = new LogStoreInputModel
            {
                Id = Guid.NewGuid(),
                AppName = faker.Internet.UserAgent(),
                OrgId = faker.Random.Number(),
                Source = faker.Internet.Url(),
                LogObjects = new List<LogObjectModel>()
            };
            for (var i = 0; i < 10; i++)
            {
                var logObject = new LogObjectModel
                {
                    UserLoginId = faker.Person.UserName,
                    Message = faker.Lorem.Sentence(),
                    TimeGenerated = faker.Date.Past(),
                    ServiceName = faker.Internet.DomainName(),
                    Priority = faker.PickRandom<LogPriority>(),
                    LogLevel = faker.PickRandom<LogsLevel>(),
                    LogCategory = faker.PickRandom<LogCategory>()
                };
                logStoreInput.LogObjects.Add(logObject);
            }

            var jsonOutput = JsonConvert.SerializeObject(logStoreInput, Formatting.Indented);
            Console.WriteLine(jsonOutput);

        }
    }
}
