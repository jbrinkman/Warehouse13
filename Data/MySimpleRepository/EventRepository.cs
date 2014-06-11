using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using MySimpleRepository.Entities;
using MySimpleRepository.Entities.DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MySimpleRepository
{
    public class EventRepository: Repository<Event>
    {

        /// <summary>
        /// The GetTags method will use the MongoDB aggregation framework to identify all the tags associated with documents in the 
        /// Event collection given the following event document structure:
        /// {
        ///   _id: ...
        ///   ...
        ///   tags: [ tag1, tag2, ... ]
        /// }
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Tag> GetTags()
        {
            throw new NotImplementedException();
        }
    }
}
