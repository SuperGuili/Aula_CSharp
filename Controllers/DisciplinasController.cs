using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;

namespace Controllers
{
    public class DisciplinasController
    {
        List<Disciplina> tabelaDisciplina = new List<Disciplina>();

        public void Inserir(Disciplina a)
        {
            tabelaDisciplina.Add(a);
        }

        public List<Disciplina> ListarTodos()
        {
            return tabelaDisciplina;
        }

        public void ExcluirDisciplina(int a)
        {
            int posicao = -1;
            int i = 0;

            foreach (Disciplina disciplina in tabelaDisciplina)
            {
                if (disciplina.Codigo == a)
                {
                    Console.WriteLine("   Disciplina " + disciplina.Materia + " excluída do sistema!");
                    posicao = i;
                }
                i++;
            }
            if (posicao >= 0)
            {
                tabelaDisciplina.RemoveAt(posicao);
            }
            else
            {
                Console.WriteLine("   Erro na exclusão!");
            }
        }
    }
}
