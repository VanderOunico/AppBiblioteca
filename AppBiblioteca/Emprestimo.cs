using Microsoft.Win32;
using System;

// Representa um empréstimo feito por um usuário para um determinado livro
public class Emprestimo
{
    public Usuario Usuario { get; set; }
    public Livro Livro { get; set; }
    public DateTime DataEmprestimo { get; set; }
    public DateTime? DataDevolucao { get; set; }
    public bool Ativo { get; private set; }

    // Construtor que associa o livro ao usuário e marca o empréstimo como ativo
    public Emprestimo(Usuario usuario, Livro livro)
    {
        Usuario = usuario;
        Livro = livro;
        DataEmprestimo = DateTime.Now;
        Ativo = true;
        Livro.MarcarComoEmprestado();
    }

    // Marca o empréstimo como encerrado e atualiza a data de devolução
    public void RegistrarDevolucao()
    {
        DataDevolucao = DateTime.Now;
        Ativo = false;
        Livro.MarcarComoDevolvido();
    }

    // Mostra as informações básicas do empréstimo no console
    public void ExibirResumo()
    {
        Console.WriteLine($"Usuário: {Usuario.Nome} | Livro: {Livro.Titulo} | Empréstimo: {DataEmprestimo.ToShortDateString()} | Devolução: {(Ativo ? "Pendente" : DataDevolucao?.ToShortDateString())}");
    }
}
