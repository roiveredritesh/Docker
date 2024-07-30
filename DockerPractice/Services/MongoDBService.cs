using DockerPractice.Model;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DockerPractice.Services
{
    public class MongoDBService
    {
        private readonly IMongoCollection<Person> _people;

        public MongoDBService(IConfiguration configuration)
        {
            var client = new MongoClient(configuration["MONGODB_CONNECTION_STRING"]);
            var database = client.GetDatabase("testdb"); // Use your database name
            _people = database.GetCollection<Person>("people"); // Use your collection name
        }
        public async Task<List<Person>> GetAsync() =>
            await _people.Find(new BsonDocument()).ToListAsync();

        public async Task CreateAsync(Person newPerson) =>
            await _people.InsertOneAsync(newPerson);
    }
}
