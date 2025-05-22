// Classe base que representa um usuário do sistema
public abstract class Usuario
{
    public string Nome { get; set; }
    public int Id { get; set; }
    public string Tipo { get; protected set; }

    // Construtor usado pelas classes derivadas (Aluno e Professor)
    // Aqui defino os dados principais do usuário ao criar o objeto
    protected Usuario(string nome, int id)
    {
        Nome = nome;
        Id = id;
    }

    // Método que será implementado nas classes filhas, para mostrar os dados do usuário
    public abstract void ExibirInformacoes();
}
