using MongoRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventLog.Data.MongoDB.Entities
{
    [Serializable]
    class App: Entity
    {
        public string Name { get; set; }
        
    }
}
