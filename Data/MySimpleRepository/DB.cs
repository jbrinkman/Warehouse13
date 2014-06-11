using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace MySimpleRepository
{
    class DB
    {
        public const string DefaultConnectionName = "MongoServerSettings";
        protected static MongoUrl GetMongoDBUrl(String connectionName)
        {
            var url = ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
            return new MongoUrl(url);
        }

        public static MongoDatabase GetDBFromConnection(String connectionName)
        {
            var url = GetMongoDBUrl(connectionName);
            var client = new MongoClient(url);
            var server = client.GetServer();
            return server.GetDatabase(url.DatabaseName);
        }
    }
}
