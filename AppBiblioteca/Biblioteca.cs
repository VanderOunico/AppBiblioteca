using System;
using System.Collections.Generic;

// Classe principal que cuida das funcionalidades da biblioteca
public class Biblioteca
{
    private List<Usuario> usuarios = new List<Usuario>();
    private List<Livro> livros = new List<Livro>();
    private List<Emprestimo> emprestimos = new List<Emprestimo>();

    // Adiciona um livro na lista de livros da biblioteca
    public void CadastrarLivro(Livro livro) => livros.Add(livro);

    // Adiciona um novo usuário (aluno ou professor) na lista de usuários
    public void CadastrarUsuario(Usuario usuario) => usuarios.Add(usuario);

    // Mostra todos os livros que foram cadastrados
    public void ListarLivros()
    {
        Console.WriteLine("\n Livros:");
        foreach (var livro in livros) livro.ExibirInformacoes();
    }

    // Mostra todos os usuários que estão cadastrados no sistema
    public void ListarUsuarios()
    {
        Console.WriteLine("\n Usuários:");
        foreach (var usuario in usuarios) usuario.ExibirInformacoes();
    }

    // Realiza um empréstimo se o livro estiver disponível e o usuário existir
    public void RealizarEmprestimo(int idUsuario, string isbnLivro)
    {
        var usuario = usuarios.Find(u => u.Id == idUsuario);
        var livro = livros.Find(l => l.ISBN == isbnLivro && l.Disponivel);

        if (usuario != null && livro != null)
        {
            var emprestimo = new Emprestimo(usuario, livro);
            emprestimos.Add(emprestimo);
            Console.WriteLine(" Empréstimo realizado com sucesso!");
        }
        else
        {
            Console.WriteLine(" Empréstimo falhou: Usuário ou livro não encontrado ou livro indisponível.");
        }
    }

    // Finaliza um empréstimo e marca o livro como devolvido
    public void DevolverLivro(string isbnLivro)
    {
        var emprestimo = emprestimos.Find(e => e.Livro.ISBN == isbnLivro && e.Ativo);
        if (emprestimo != null)
        {
            emprestimo.RegistrarDevolucao();
            Console.WriteLine(" Livro devolvido com sucesso!");
        }
        else
        {
            Console.WriteLine(" Nenhum empréstimo ativo encontrado para esse livro.");
        }
    }

    // Mostra um resumo de todos os empréstimos já realizados (ativos ou não)
    public void ExibirRelatorioEmprestimos()
    {
        Console.WriteLine("\n Relatório de Empréstimos:");
        foreach (var emprestimo in emprestimos)
        {
            emprestimo.ExibirResumo();
        }
    }
}
