// Representa um professor cadastrado no sistema, herda da classe Usuario
public class Professor : Usuario
{
    public string Departamento { get; set; }
    public string Registro { get; set; }

    // Construtor que define os dados do professor e marca o tipo como "Professor"
    public Professor(string nome, int id, string departamento, string registro) : base(nome, id)
    {
        Departamento = departamento;
        Registro = registro;
        Tipo = "Professor";
    }

    // Mostra no console as informações completas do professor
    public override void ExibirInformacoes()
    {
        Console.WriteLine($"[Professor] Nome: {Nome}, ID: {Id}, Departamento: {Departamento}, Registro: {Registro}");
    }
}
