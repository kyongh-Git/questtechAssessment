using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QTassessment.Controllers
{
    [ApiController]
    [Route("item-types")]
    public class ItemTypeController : ControllerBase
    {
        private readonly ILogger<ItemTypeController> _logger;

        public ItemTypeController(ILogger<ItemTypeController> logger)
        {
            _logger = logger;
        }

        [HttpGet] // Find item types
        public IEnumerable<Item> GetItemTypes()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new Item
            {
                //Date = DateTime.Now.AddDays(index),
                //TemperatureC = rng.Next(-20, 55),
                //Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet("{itemTypeId}")] // Get itemType by iD
        public IEnumerable<Item> GetItemTypeById()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new Item
            {
                //Date = DateTime.Now.AddDays(index),
                //TemperatureC = rng.Next(-20, 55),
                //Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }


        [HttpPost] // Add a new item type to inventory
        public IEnumerable<Item> PostItemType()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new Item
            {
                //Date = DateTime.Now.AddDays(index),
                //TemperatureC = rng.Next(-20, 55),
                //Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpPut("{itemTypeId}")] // Updates a item in the store with form data
        public IEnumerable<Item> PutItemTypeById()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new Item
            {
                //Date = DateTime.Now.AddDays(index),
                //TemperatureC = rng.Next(-20, 55),
                //Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpDelete("{itemTypeId}")] // Deletes a item
        public IEnumerable<Item> DeleteItemTypeById()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new Item
            {
                //Date = DateTime.Now.AddDays(index),
                //TemperatureC = rng.Next(-20, 55),
                //Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
