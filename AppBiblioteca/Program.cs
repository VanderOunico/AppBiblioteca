using System;

class Program
{
    static void Main(string[] args)
    {
        //Criando um objeto da classe
        Biblioteca biblioteca = new Biblioteca();
        int opcao;

        //loop while. deixar bibilioteca com o funcionamento continuo
       
        do
        {
            Console.WriteLine("\n Sistema da Biblioteca");
            Console.WriteLine("1. Cadastrar Livro");
            Console.WriteLine("2. Cadastrar Aluno");
            Console.WriteLine("3. Cadastrar Professor");
            Console.WriteLine("4. Realizar Empréstimo");
            Console.WriteLine("5. Devolver Livro");
            Console.WriteLine("6. Listar Livros");
            Console.WriteLine("7. Listar Usuários");
            Console.WriteLine("8. Relatório de Empréstimos");
            Console.WriteLine("0. Sair");
            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            //interpretar a escolha do usuário
            switch (opcao)
            {
                case 1:
                    Console.Write("Título: ");
                    string titulo = Console.ReadLine();
                    Console.Write("Autor: ");
                    string autor = Console.ReadLine();
                    Console.Write("Ano: ");
                    int ano = int.Parse(Console.ReadLine());
                    Console.Write("ISBN: ");
                    string isbn = Console.ReadLine();
                    biblioteca.CadastrarLivro(new Livro(titulo, autor, ano, isbn));
                    break;
                case 2:
                    Console.Write("Nome: ");
                    string nomeAluno = Console.ReadLine();
                    Console.Write("ID: ");
                    int idAluno = int.Parse(Console.ReadLine());
                    Console.Write("Curso: ");
                    string curso = Console.ReadLine();
                    Console.Write("Matrícula: ");
                    string matricula = Console.ReadLine();
                    biblioteca.CadastrarUsuario(new Aluno(nomeAluno, idAluno, curso, matricula));
                    break;
                case 3:
                    Console.Write("Nome: ");
                    string nomeProf = Console.ReadLine();
                    Console.Write("ID: ");
                    int idProf = int.Parse(Console.ReadLine());
                    Console.Write("Departamento: ");
                    string departamento = Console.ReadLine();
                    Console.Write("Registro: ");
                    string registro = Console.ReadLine();
                    biblioteca.CadastrarUsuario(new Professor(nomeProf, idProf, departamento, registro));
                    break;
                case 4:
                    Console.Write("ID do Usuário: ");
                    int idEmprestimo = int.Parse(Console.ReadLine());
                    Console.Write("ISBN do Livro: ");
                    string isbnEmprestimo = Console.ReadLine();
                    biblioteca.RealizarEmprestimo(idEmprestimo, isbnEmprestimo);
                    break;
                case 5:
                    Console.Write("ISBN do Livro para Devolução: ");
                    string isbnDevolucao = Console.ReadLine();
                    biblioteca.DevolverLivro(isbnDevolucao);
                    break;
                case 6:
                    biblioteca.ListarLivros();
                    break;
                case 7:
                    biblioteca.ListarUsuarios();
                    break;
                case 8:
                    biblioteca.ExibirRelatorioEmprestimos();
                    break;
                case 0:
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        } while (opcao != 0);
    }
}