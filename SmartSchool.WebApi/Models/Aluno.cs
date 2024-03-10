using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSchool.WebApi.Models
{


    public class Aluno
    {
        
        public Aluno() {}

        public Aluno(string nome, string sobrenome, string telefone)
        {
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.Telefone = telefone;

        }
        public int Id { get; set; }
        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public string Telefone { get; set; }

        public IEnumerable<AlunoDisciplina> AlunoDisciplinas {get; set; }
    }
}