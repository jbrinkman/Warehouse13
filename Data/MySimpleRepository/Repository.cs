using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Driver.Linq;
using MySimpleRepository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace MySimpleRepository
{
    /// <summary>
    /// The Repository is a simple wrapper around the MongoDB driver in order to abstract out all of the data access.  
    /// Repository users should not know any of the implementation details of the underlying database. 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Repository<T> 
        where T : Entity
    {

    }
}
