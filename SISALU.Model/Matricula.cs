using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISALU.Model
{
    public class Matricula
    {
        public int Id { get; set; }
        public int IdAluno { get; set; }
        public int IdCurso { get; set; }
        public int IdTurno { get; set; }
        public int IdTurma { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataMatricula { get; set; }

        public Aluno aluno { get; set; }
        public Turno turno { get; set; }
        public Curso curso { get; set; }
        public Turma turma { get; set; }

    }
}
