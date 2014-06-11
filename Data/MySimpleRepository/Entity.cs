using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MySimpleRepository
{
    [Serializable]
    [BsonIgnoreExtraElements(Inherited = true)]
    public abstract class Entity
    {
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonId]
        public virtual string Id { get; set; }
    }
}
