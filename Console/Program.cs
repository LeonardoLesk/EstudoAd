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


            Aluno alunoZero = new Aluno()
            {
                id = 0,
                nome = "LeonardoZero",
                cpf = "377.534.858/10",
                rg = "39.360.895-0"
            };

            addAluno(alunoZero);

            Aluno alunoUm = new Aluno()
            {
                id = 1,
                nome = "Leonardo",
                cpf = "377.534.858/14",
                rg = "39.360.895-5"
            };

            addAluno(alunoUm);

            Curso cursoUm = new Curso()
            {
                idCurso = 1,
                nome = "Curso Um",
                aulas = 20,
                valorBase = 129.99
            };

            addCurso(cursoUm);

            Turma turmaUm = new Turma()
            {
                idTurma = 1,
                alunos = alunos,
                curso = cursoUm,
                vagas = 10
            };

            addTurma(turmaUm);

            Empresa empresaUm = new Empresa()
            {
                idEmpresa = 1,
                cnpj ="333.333.333/22",
                nome = "Ad Agency"
            };

            addEmpresa(empresaUm);

            Matricula matriculaZero = new Matricula()
            {
                idMatricula = 0,
                aluno = alunoZero,
                turma = turmaUm,
                empresa = empresaUm,
                valorFinal = cursoUm.valorBase
            };

            Matricular(matriculaZero);

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

            foreach (var matriculado in matriculas)
            {
                if (matriculado.idMatricula == matricula.idMatricula)
                {
                    throw new Exception("Id de matricula já registrado");
                }
            }

            // for varrendo matriculas e verificando ids, se encontrar o mesmo id, throw exception
            //for (int i = 0; i < matriculas.Count; i++)
            //{
            //    if(matricula.idMatricula == matriculas[i].idMatricula)
            //    {
            //        throw new Exception("Id de matricula já matriculado");
            //    }   
            //}

            // adiciona matricula
            matriculas.Add(matricula);
        }

        public static void addAluno(Aluno aluno)
        {
            foreach (var varAluno in alunos)
            {
                if (varAluno.id == aluno.id)
                {
                    throw new Exception("Id de aluno já registrado");
                }
            }

            alunos.Add(aluno);
        }
        
        public static void addCurso(Curso curso)
        {
            foreach (var varCurso in cursos)
            {
                if (varCurso.idCurso == curso.idCurso)
                {
                    throw new Exception("Id de curso já registrado");
                }
            }

            cursos.Add(curso);
        }

        public static void addTurma(Turma turma)
        {
            foreach (var varTurma in turmas)
            {
                if (varTurma.idTurma == turma.idTurma)
                {
                    throw new Exception("Id de turma já registrado");
                }
            }

            turmas.Add(turma);
        }

        public static void addEmpresa(Empresa empresa)
        {
            foreach (var varEmpresa in empresas)
            {
                if (varEmpresa.idEmpresa == empresa.idEmpresa)
                {
                    throw new Exception("Id de empresa já registrado");
                }
            }

            empresas.Add(empresa);
        }
    }
}