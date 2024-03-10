using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSchool.WebApi.Models
{
    public class Disciplina
    {
        public Disciplina()
        {

        }

        public Disciplina(int id, string nome, int professorId, Professor professor)
        {
            this.Id = id;
            this.Nome = nome;
            this.ProfessorId = professorId;
            this.professor = professor;

        }
        public int Id { get; set; }

        public string Nome { get; set; }

        public int ProfessorId { get; set; }

        public Professor professor { get; set; }

        public IEnumerable<AlunoDisciplina> AlunoDisciplinas {get; set; }
    }
}