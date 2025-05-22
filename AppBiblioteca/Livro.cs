// Representa um livro cadastrado na biblioteca
public class Livro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int Ano { get; set; }
    public string ISBN { get; set; }
    public bool Disponivel { get; private set; } = true;

    // Construtor que define os dados do livro ao ser criado
    public Livro(string titulo, string autor, int ano, string isbn)
    {
        Titulo = titulo;
        Autor = autor;
        Ano = ano;
        ISBN = isbn;
    }

    // Marca o livro como emprestado (fica indisponível)
    public void MarcarComoEmprestado() => Disponivel = false;

    // Marca o livro como devolvido (disponível novamente)
    public void MarcarComoDevolvido() => Disponivel = true;

    // Mostra as informações do livro no console
    public void ExibirInformacoes()
    {
        Console.WriteLine($"Título: {Titulo}, Autor: {Autor}, Ano: {Ano}, ISBN:
