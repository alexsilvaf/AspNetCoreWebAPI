using System.Collections.Generic;

namespace SmartScholl.WebAPI.Models
{
    //A disciplina tem id, nome e um professor id
    public class Disciplina
    {
        public Disciplina() { }

        public Disciplina(int id, string nome, int professorId)
        {
            this.Id = id;
            this.Nome = nome;
            this.ProfessorId = ProfessorId;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public int ProfessorId { get; set; }
        public Professor Professor { get; set; }

        private IEnumerable<AlunoDisciplina> AlunosDisciplinas { get; set; }
    }
}