using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MySimpleRepository.Entities.DataObjects;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace MySimpleRepository.Entities
{
    [Serializable]
    public class Event : Entity
    {
        public string EventType { get; set; }
        
        public ErrorDetails CustomData { get; set; }
        
        public List<string> Tags { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string AppId { get; set; }
        
        public string AppVersion { get; set; }

    }
}
