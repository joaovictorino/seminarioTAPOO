using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Models
{
    public class Teste
    {
        [BsonElement("Name")]
        public string Name { get; set; }
    }
}