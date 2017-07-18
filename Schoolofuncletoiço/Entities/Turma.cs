using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolofuncletoiço.Entities
{
    public class Turma
    {
        public int idTurma;
        public int vagas;
        public Curso curso;
        public List<Aluno> alunos;
    }
}
