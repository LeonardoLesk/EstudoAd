using Schoolofuncletoiço.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    class Program
    {
        private static List<Aluno> alunos;
        private static List<Curso> cursos;
        private static List<Turma> turmas;
        private static List<Empresa> empresas;
        private static List<Matricula> matriculas;

        static void Main(string[] args)
        {
            alunos = new List<Aluno>();
            cursos = new List<Curso>();
            turmas = new List<Turma>();
            empresas = new List<Empresa>();
            matriculas = new List<Matricula>();

            Aluno alunoUm = new Aluno()
            {
                id = 1,
                nome = "Leonardo",
                cpf = "377.534.858/14",
                rg = "39.360.895-5"
            };

            alunos.Add(alunoUm);

            Curso cursoUm = new Curso()
            {
                idCurso = 1,
                nome = "Curso Um",
                aulas = 20,
                valorBase = 129.99
            };

            cursos.Add(cursoUm);

            Turma turmaUm = new Turma()
            {
                idTurma = 1,
                alunos = alunos,
                curso = cursoUm,
                vagas = 10
            };

            turmas.Add(turmaUm);

            Empresa empresaUm = new Empresa()
            {
                idEmpresa = 1,
                cnpj ="333.333.333/22",
                nome = "Ad Agency"
            };

            empresas.Add(empresaUm);

            Matricula matriculaUm = new Matricula()
            {
                idMatricula = 1,
                aluno = alunoUm,
                turma = turmaUm,
                empresa = empresaUm,
                valorFinal = cursoUm.valorBase
            };

            Matricular(matriculaUm);

            Matricular(new Matricula()
            {
                idMatricula = 1,
                aluno = alunoUm,
                turma = turmaUm,
                empresa = empresaUm,
                valorFinal = cursoUm.valorBase * .9
            });

            var alunos_da_empresa =  matriculas.Where(x => x.empresa.idEmpresa == 1);
        }

        public static void Matricular(Matricula matricula)
        {
            bool id_ja_existente = true;


            for (int i = 0; i < matriculas.Count; i++)
            {
                if (matricula.idMatricula == matriculas[i].idMatricula)
                {
                    id_ja_existente = true;
                }
                else
                {
                    id_ja_existente = false;
                }
                

            }

            if (id_ja_existente == false)
            {
                matriculas.Add(matricula);
            }
            else
            {
                throw new Exception("Id de matricula já utilizado");
            }
        }
    }
}