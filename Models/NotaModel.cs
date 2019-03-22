using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace Models
{
    public class NotaModel
    {
        public NotaModel()
        {
            Notas = new List<Nota>();            
        }
        public List<Nota> Notas { get; set; }
    }
}