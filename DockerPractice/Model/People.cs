using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace DockerPractice.Model
{
    public class Person
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        private string Id { get; set; }

        [BsonElement("Name")]
        public string Name { get; set; }

        [BsonElement("ContactNumber")]
        public string ContactNumber { get; set; }

        [BsonElement("Email")]
        public string Email { get; set; }

        [BsonElement("Address")]
        public string Address { get; set; }
    }
}
