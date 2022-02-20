using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using QTassessment.Infrastructure;

namespace QTassessment.Controllers
{
    [ApiController]
    [Route("items")]
    public class ItemController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ItemController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet] // Get all items
        public IEnumerable<Item> GetItems()
        {
            var items = _context.Items.FindAsync();

            if (items == null)
            {
                return NotFound();
            }

            return items;
        }

        [HttpGet("findByItemType")] // Finds items by Itemtype
        public IEnumerable<Item> GetItemsByItemType()
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

        [HttpGet("{itemId}")] // Find item by ID
        public async IEnumerable<Item> GetItemById(long id)
        {
            var items = await _context.Items.FindAsync(id);

            if (items == null)
            {
                return NotFound();
            }

            return items;
        }


        [HttpPost] // Create an item
        public IEnumerable<Item> PostItem()
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

        [HttpPut("{itemId}")] // Updates a item in the store with form data
        public async IEnumerable<Item> PutItemById(long id)
        {
            if (id != todoItem.Id)
            {
                return BadRequest();
            }

            ApplicationDbContext.Entry(todoItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TodoItemExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpDelete("{itemId}")] // Deletes a item
        public async IEnumerable<Item> DeleteItemById(long itemId)
        {
            var todoItem = await _context.Items.FindAsync(itemId);
            if (todoItem == null)
            {
                return NotFound();
            }

            _context.Items.Remove(todoItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
