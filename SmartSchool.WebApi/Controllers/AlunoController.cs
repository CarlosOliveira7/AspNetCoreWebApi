using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SmartSchool.WebApi.Models;

namespace SmartSchool.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {

        public static int proxId = 0;
        public static List<Aluno> Alunos = new List<Aluno>()
        {
        };

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Alunos);
        }


        [HttpGet("byName")]
        public IActionResult GetByName(string nome)
        {

            var aluno = Alunos.FirstOrDefault(s => s.Nome  == nome);
            if (aluno == null)
            {
                return NotFound("Aluno não encontrado");
            }

            return Ok(aluno);
        }

        [HttpGet("byId/{id}")]
        public IActionResult GetById(int Id)
        {

            var aluno = Alunos.FirstOrDefault(s => s.Id == Id);
            if (aluno == null)
            {
                return NotFound("Aluno não encontrado");
            }

            return Ok(aluno);
        }

        [HttpPost]
        public IActionResult Post(int id, string nome, string sobrenome, string telefone)
        {
            Alunos.Add(new Aluno(){
                Id = proxId++,
                Nome = nome,
                Sobrenome = sobrenome,
                Telefone = telefone
            });

            return Ok(Alunos);
        }


        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Aluno novoAluno)
        {
            var aluno = Alunos.SingleOrDefault(e => e.Id == id);
            if(aluno == null)
            {
                return NotFound();
            }
            aluno.Nome = novoAluno.Nome;
            aluno.Sobrenome = novoAluno.Sobrenome;
            aluno.Telefone = novoAluno.Telefone;

            return Ok(aluno);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var aluno = Alunos.SingleOrDefault(e => e.Id == id);
            if(aluno == null)
            {
                return NotFound();
            }

            Alunos.Remove(aluno);

            return Ok();
        }
    }
}