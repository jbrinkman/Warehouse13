using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using MySimpleRepository;
using MySimpleRepository.Entities;
using MongoDB.Driver.Linq;
using MySimpleRepository.Entities.DataObjects;

namespace EventLog.Services
{
    [RoutePrefix("api/simpleevent")]
    public class SimpleEventController : ApiController
    {
        public SimpleEventController()
            : this(new EventRepository())
        {
        }

        public SimpleEventController(EventRepository repo)
        {
            EventRepo = repo;
        }

        public EventRepository EventRepo { get; private set; }

        public IEnumerable<Event> Get()
        {
            return EventRepo;
        }

        public Event Get(String id)
        {
            return EventRepo.GetById(id);
        }

        [Route("tags")]
        public IEnumerable<Tag> GetTags()
        {
            return EventRepo.GetTags();
        }

        public void Delete(String id)
        {
            EventRepo.Delete(id);
        }

        public void Post([FromBody]Event entity)
        {
            EventRepo.Add(entity);
        }
    }
}
