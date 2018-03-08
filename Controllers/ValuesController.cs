using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace janapi.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private TodoItem todo;
        //private readonly ITodoRepository _todoRepository;
        private readonly ILogger _logger;
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            //return "value";
            //TodoItem todo = new TodoItem(333);
            //todo.Kd = 50;
            if(id==0)
            {
                if(todo != null)
                {
                   return $"{id}: {todo.Name} ";
                } 
                else
                {
                    return "todo == null !!! ";
                }  
            }
            else
            {
                return $"{id} {new TodoItem().Kd} ";
            }
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]TodoItem pTodo)
        {
            _logger.LogInformation("Hello, *********");
            todo = pTodo;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}