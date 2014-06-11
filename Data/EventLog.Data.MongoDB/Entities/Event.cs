using MongoRepository;
using System;
using System.Collections.Generic;


namespace EventLog.Data.MongoDB.Entities
{
    [Serializable]
    public class Event : Entity
    {
        public string EventType { get; set; }
        public Event CustomData { get; set; }
        public List<string> Tags { get; set; }
        public string AppId { get; set; }
        public string AppVersion { get; set; }

    }
}
