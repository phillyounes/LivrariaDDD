using System.Collections.Generic;
using LivrariaDDD.Application.Interfaces;
using LivrariaDDD.Application.ViewModel;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LivrariaDDD.PresentationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivroController : ControllerBase
    {
        private readonly ILivroApp _livroApp;
        public LivroController(ILivroApp livroApp)
        {
            _livroApp = livroApp;
        }

        // GET: api/<LivroController>
        [HttpGet]
        public IEnumerable<LivroViewModel> Get()
        {
            return _livroApp.ReadAll();
        }

        // GET api/<LivroController>/5
        [HttpGet("{id}")]
        public LivroViewModel Get(int id)
        {
            return _livroApp.Read(id);
        }

        // POST api/<LivroController>
        [HttpPost]
        public void Post([FromBody] LivroViewModel livroViewModel)
        {
            _livroApp.Create(livroViewModel);
        }

        // PUT api/<LivroController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] LivroViewModel livroViewModel)
        {
            _livroApp.Update(livroViewModel);
        }

        // DELETE api/<LivroController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var livroViewModel = _livroApp.Read(id);
            _livroApp.Delete(livroViewModel);
        }
    }
}
