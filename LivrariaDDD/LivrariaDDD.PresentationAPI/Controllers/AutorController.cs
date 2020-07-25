using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LivrariaDDD.Application.Interfaces;
using LivrariaDDD.Application.ViewModel;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LivrariaDDD.PresentationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutorController : ControllerBase
    {
        private readonly IAutorApp _autorApp;
        public AutorController(IAutorApp autorApp)
        {
            _autorApp = autorApp;
        }

        // GET: api/<AutorController>
        [HttpGet]
        public IEnumerable<AutorViewModel> Get()
        {
            return _autorApp.ReadAll();
        }

        // GET api/<AutorController>/5
        [HttpGet("{id}")]
        public AutorViewModel Get(int id)
        {
            return _autorApp.Read(id);
        }

        // POST api/<AutorController>
        [HttpPost]
        public void Post([FromBody] AutorViewModel autorViewModel)
        {
            _autorApp.Create(autorViewModel);
        }

        // PUT api/<AutorController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] AutorViewModel autorViewModel)
        {
            _autorApp.Update(autorViewModel);
        }

        // DELETE api/<AutorController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var autorViewModel = _autorApp.Read(id);
            _autorApp.Delete(autorViewModel);
        }
    }
}
