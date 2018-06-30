using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;

namespace Controllers
{
    public class ProfessoresController
    {
        List<Professor> tabelaProfessores = new List<Professor>();

        public void Inserir(Professor a)
        {
            tabelaProfessores.Add(a);
        }

        public List<Professor> ListarTodos()
        {
            return tabelaProfessores;
        }

        public void ExcluirProfessor(string a)
        {
            int posicao = -1;
            int i = 0;

            foreach (Professor professor in tabelaProfessores)
            {
                if (professor.Cpf == a)
                {
                    Console.WriteLine("   Professor: " + professor.Nome + " - CPF: " + professor.Cpf + " - excluído do sistema!");
                    posicao = i;
                }
                i++;
            }
            if (posicao >= 0)
            {
                tabelaProfessores.RemoveAt(posicao);
            }
            else
            {
                Console.WriteLine("   Erro na exclusão!");
            }
        }
    }
}
