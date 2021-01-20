using CodeFirstEFcore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstEFcore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
       
        [HttpGet]
        public IEnumerable<Publisher> Get()
        {
            using (var _context = new BookStoresDBContext())
            {
                //Publisher publisher = new Publisher();
                //publisher.PublisherName = "Max Payne";
                //_context.Publishers.Add(publisher);
                //_context.SaveChanges();

                //Update first publisher always.........................................
                //Publisher publisher = _context.Publishers.FirstOrDefault();
                //publisher.PublisherName = "Max Payne II";
                //_context.SaveChanges();

                //Remove the first publisher in the list always......................................
                Publisher publisher = _context.Publishers.FirstOrDefault();
                _context.Publishers.Remove(publisher);
                _context.SaveChanges();


                return _context.Publishers.ToList();
            }

               
            
            
        }
    }
}
