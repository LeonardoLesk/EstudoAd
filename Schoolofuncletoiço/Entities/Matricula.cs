using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolofuncletoiço.Entities
{
    public class Matricula
    {
        public int idMatricula;
        public Turma turma;
        public Aluno aluno;
        public Empresa empresa;
        public double valorFinal;
    }
}
