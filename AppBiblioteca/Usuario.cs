// Classe base que representa um usu�rio do sistema
public abstract class Usuario
{
    public string Nome { get; set; }
    public int Id { get; set; }
    public string Tipo { get; protected set; }

    // Construtor usado pelas classes derivadas (Aluno e Professor)
    // Aqui defino os dados principais do usu�rio ao criar o objeto
    protected Usuario(string nome, int id)
    {
        Nome = nome;
        Id = id;
    }

    // M�todo que ser� implementado nas classes filhas, para mostrar os dados do usu�rio
    public abstract void ExibirInformacoes();
}
