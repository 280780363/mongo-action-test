using MongoDB.Driver;
using Xunit;

namespace test;

public class Tests
{
    [Fact]
    public void DoTest()
    {
        var mongoClient = new MongoClient("mongodb://mongo:123123@localhost:27017/?authSource=admin");
        mongoClient.GetDatabase("test").CreateCollection("test");
    }
}