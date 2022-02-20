using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QTassessment.Controllers
{
    [ApiController]
    [Route("items")]
    public class InspectionController : ControllerBase
    {
        private readonly ILogger<InspectionController> _logger;

        public InspectionController(ILogger<InspectionController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{itemId}/inspections")] // Find item types
        public IEnumerable<Item> GetInspections()
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

        [HttpGet("{itemId}/inspections/{inspectionId}")] // Get itemType by iD
        public IEnumerable<Item> GetInspectionsById()
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


        [HttpPost("{itemId}/inspections")]
        public IEnumerable<Item> PostInspection()
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

        [HttpPut("{itemId}/inspections/{inspectionId}")] // Updates a item in the store with form data
        public IEnumerable<Item> PutInspectionById()
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

        [HttpDelete("{itemId}/inspections/{inspectionId}")] // Deletes a item
        public IEnumerable<Item> DeleteInspectionById()
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
