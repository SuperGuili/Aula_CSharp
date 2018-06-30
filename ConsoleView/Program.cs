using Controllers;
using Modelos;
using System;

namespace ConsoleView
{
    class Program
    {
        static void Main()
        {
            AlunosController alunosController = new AlunosController();
            ProfessoresController professoresController = new ProfessoresController();
            DisciplinasController disciplinasController = new DisciplinasController();

            Console.ForegroundColor = ConsoleColor.Green;

            start:
            
            Console.WriteLine("ADS - Desen. com C# - UP - Luiz Guilherme Luize Pereira");
            Console.WriteLine();
            Console.WriteLine("   ------------------------------------------------");
            Console.WriteLine("   ------ MENU PRINCIPAL - CADASTRO ESCOLAR -------");
            Console.WriteLine("   ------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("   Digite o NÚMERO desejado");
            Console.WriteLine();
            Console.WriteLine("   1. Cadastar Aluno");
            Console.WriteLine("   2. Listar Alunos");
            Console.WriteLine("   3. Excluir Aluno");
            Console.WriteLine("   4. Cadastar Professor");
            Console.WriteLine("   5. Listar Professores");
            Console.WriteLine("   6. Excluir Professor");
            Console.WriteLine("   7. Cadastar Disciplina");
            Console.WriteLine("   8. Listar Disciplina");
            Console.WriteLine("   9. Excluir Disciplina");
            Console.WriteLine("   0. Sair");

            int menu = int.Parse(Console.ReadLine());

            switch (menu)
            {
                case 1:
                    Console.WriteLine("   Pressione ESC para voltar ao Menu Principal");
                    Console.WriteLine();
                    do
                    {
                        //Cadastrar Alunos
                        Aluno a = CadastrarAluno();
                        alunosController.Inserir(a);
                    } while (Console.ReadKey().Key != ConsoleKey.Escape);
                    Console.Clear();
                    goto start;

                case 2:
                    //Imprimir Alunos
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("   ----------LISTA DE ALUNOS MATRICULADOS----------");
                    foreach (Aluno aluno in alunosController.ListarTodos())
                    {
                        ImprimirDadosAluno(aluno);
                    }
                    goto start;

                case 3:
                    //Excluir Aluno
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("   ----------LISTA DE ALUNOS MATRICULADOS----------");
                    foreach (Aluno aluno in alunosController.ListarTodos())
                    {
                        ImprimirDadosAluno(aluno);
                    }
                    Console.WriteLine("   Digite a matrícula do aluno para excluir:");
                    int mat = int.Parse(Console.ReadLine());
                    alunosController.ExcuirAluno(mat);
                    goto start;
                
                case 4:
                    Console.WriteLine("   Pressione ESC para voltar ao Menu Principal");
                    Console.WriteLine();
                    do
                    {
                        //Cadastrar Professores
                        Professor prof = CadastrarProfessor();
                        professoresController.Inserir(prof);
                    } while (Console.ReadKey().Key != ConsoleKey.Escape);
                    Console.Clear();
                    goto start;

                case 5:
                    //Imprimir Professores
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("   --------LISTA DE PROFESSORES DA ESCOLA---------");
                    foreach (Professor professor in professoresController.ListarTodos())
                    {
                        ImprimirDadosProfessor(professor);
                    }
                    goto start;


                case 6:
                    //Excluir Professor
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("   --------LISTA DE PROFESSORES DA ESCOLA---------");
                    foreach (Professor professor in professoresController.ListarTodos())
                    {
                        ImprimirDadosProfessor(professor);
                    }
                    Console.WriteLine("   Digite o CPF do Professor para excluir:");
                    string cpf = Console.ReadLine();
                    professoresController.ExcluirProfessor(cpf);
                    goto start;

                case 7:
                    Console.WriteLine("   Pressione ESC para voltar ao Menu Principal");
                    Console.WriteLine();
                    do
                    {
                        //Cadastrar Disciplinas
                        Disciplina disciplina = CadastrarDisciplina();
                        disciplinasController.Inserir(disciplina);
                    } while (Console.ReadKey().Key != ConsoleKey.Escape);
                    Console.Clear();
                    goto start;

                case 8:
                    //Imprimir Disciplinas
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("   --------LISTA DE DISCIPLINAS DA ESCOLA---------");
                    foreach (Disciplina Materia in disciplinasController.ListarTodos())
                    {
                        ImprimirDadosDisciplina(Materia);
                    }
                    goto start;

                case 9:
                    //Excluir Disciplina
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("   --------LISTA DE DISCIPLINAS DA ESCOLA---------");
                    foreach (Disciplina Materia in disciplinasController.ListarTodos())
                    {
                        ImprimirDadosDisciplina(Materia);
                    }
                    Console.WriteLine("   Digite o Código da Disciplina para excluir:");
                    int codigo = int.Parse(Console.ReadLine());
                    disciplinasController.ExcluirDisciplina(codigo);
                    goto start;

                case 0:
                    break;

                default:
                    Console.WriteLine("   Opção inexistente, tente outra vez ou digite 0 para sair");
                    goto start;
            }        
            
        }

        //Função Cadastrar Aluno
        private static Aluno CadastrarAluno()
        {
            Aluno a = new Aluno();

            Console.Write("   Digite o nome do aluno: ");
            a.Nome = Console.ReadLine(); //set

            Console.Write("   Digite o numero da matricula: ");
            a.Matricula = int.Parse(Console.ReadLine()); //set para int

            Console.WriteLine("   ------------------------------------------------");

            return a;
        }

        //Função Imprimir Alunos
        private static void ImprimirDadosAluno(Aluno a)
        {
            Console.WriteLine("   Matricula: " + a.Matricula + " - Aluno: " + a.Nome); // get
            Console.WriteLine("   ------------------------------------------------");
        }

        //Função Cadastrar Professor
        private static Professor CadastrarProfessor()
        {
            Professor a = new Professor();

            Console.Write("   Digite o nome do Professor: ");
            a.Nome = Console.ReadLine(); //set

            Console.Write("   Digite o numero do CPF: ");
            a.Cpf = Console.ReadLine(); //set

            Console.WriteLine("   ------------------------------------------------");

            return a;
        }

        //Função Imprimir Professores
        private static void ImprimirDadosProfessor(Professor a)
        {
            Console.WriteLine("   CPF: " + a.Cpf + " - Professor: " + a.Nome); // get
            Console.WriteLine("   ------------------------------------------------");
        }

        //Função Cadastrar Disciplina
        private static Disciplina CadastrarDisciplina()
        {
            Disciplina a = new Disciplina();

            Console.Write("   Digite o nome da Disciplina: ");
            a.Materia = Console.ReadLine(); //set

            Console.Write("   Digite o Código da Disciplina: ");
            a.Codigo = int.Parse(Console.ReadLine()); //set para int

            Console.WriteLine("   ------------------------------------------------");

            return a;
        }

        //Função Imprimir Disciplinas
        private static void ImprimirDadosDisciplina(Disciplina a)
        {
            Console.WriteLine("   Código: " + a.Codigo + " - Disciplina: " + a.Materia); //get
            Console.WriteLine("   ------------------------------------------------");
        }

    }
}
