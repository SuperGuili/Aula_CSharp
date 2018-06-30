using Modelos;
using System;
using System.Collections.Generic;

namespace Controllers
{
    public class AlunosController
    {
        List<Aluno> tabelaAlunos = new List<Aluno>();

        public void Inserir(Aluno a)
        {
            tabelaAlunos.Add(a);
        }

        public List<Aluno> ListarTodos()
        {
            return tabelaAlunos;
        }

        public void ExcuirAluno(int a)
        {
            int posicao = -1;
            int i = 0;

            foreach (Aluno aluno in tabelaAlunos)
            {
                if (aluno.Matricula == a)
                {
                    Console.WriteLine("   Aluno: " + aluno.Nome + " - matrícula: " + aluno.Matricula + " - excluído do sistema!");
                    posicao = i;
                }
                i++;
            }
            if(posicao >= 0)
            {
                tabelaAlunos.RemoveAt(posicao);
            }
            else
            {
                Console.WriteLine("   Erro na exclusão!");
            }
        }
    }
}
