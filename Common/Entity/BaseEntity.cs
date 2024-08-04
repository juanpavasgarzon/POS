using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Common.Entity;

public abstract record BaseEntity
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public required string Id { get; set; }
}