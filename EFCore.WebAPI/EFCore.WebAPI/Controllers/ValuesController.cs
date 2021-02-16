using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCore.WebAPI.Data;
using EFCore.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace EFCore.WebAPI.Controllers
{
    [Route("api/pessoa")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Pessoa>> Get()
        {
            using (var context = new PessoaContext())
            {
                return context.Pessoas.ToList();
            }
        }

        [HttpGet("{id}")]
        public ActionResult<Pessoa> Get(int id)
        {
            using (var context = new PessoaContext())
            {
                return context.Pessoas.Where(e => e.Id == id).FirstOrDefault();
            }
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Pessoa value)
        {
            using (var context = new PessoaContext())
            {
                context.Pessoas.Add(value);
                context.SaveChanges();
            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Pessoa value)
        {
            using (var context = new PessoaContext())
            {
                var pessoa = context.Pessoas.Where(e => e.Id == id).FirstOrDefault();
                pessoa.Nome = value.Nome;
                context.SaveChanges();
            }
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            using (var context = new PessoaContext())
            {
                var pessoa = context.Pessoas.Where(e => e.Id == id).FirstOrDefault();
                context.Pessoas.Remove(pessoa);
                context.SaveChanges();
            }
        }
    }
}
