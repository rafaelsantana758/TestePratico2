using Microsoft.AspNetCore.Mvc;
using TestePratico2.models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestePratico2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        // GET: api/<ClienteController>
        [HttpGet]
        public IEnumerable<ClienteModels> Get()
        {
            List<ClienteModels> clienteModels = new List<ClienteModels>();
            clienteModels.Add(new ClienteModels() { Id = 1, cliente = "Rafael Santana", container = "cheio" });
            return clienteModels;
        }

        // GET api/<ClienteController>/5
        [HttpGet("{id}")]
        public ClienteModels Get(int id)
        {
            ClienteModels cliente = new ClienteModels() { Id = 1, cliente = "Rafael Santana", container = "cheio" };
            return cliente;
        }

        // POST api/<ClienteController>
        [HttpPost]
        public void Post([FromBody] ClienteModels cliente)
        {
        }

        // PUT api/<ClienteController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ClienteModels cliente)
        {
        }

        // DELETE api/<ClienteController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
