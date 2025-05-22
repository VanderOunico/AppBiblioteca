// Classe Aluno que deriva da classe base Usuario
public class Aluno : Usuario
{
    // Armazena o curso em que o aluno está matriculado
    public string Curso { get; set; }

    // Guarda o número de matrícula do aluno
    public string Matricula { get; set; }

    // Construtor que define os dados do aluno ao instanciar o objeto
    // Passa nome e id para a classe base, e define curso e matrícula aqui
    public Aluno(string nome, int id, string curso, string matricula) : base(nome, id)
    {
        Curso = curso;           // Salva o curso informado
        Matricula = matricula;   // Salva a matrícula informada
        Tipo = "Aluno";          // Define que esse usuário é do tipo Aluno
    }

    // Método sobrescrito para mostrar as informações completas do aluno no console
    public override void ExibirInformacoes()
    {
        Console.WriteLine($"[Aluno] Nome: {Nome}, ID: {Id}, Curso: {Curso}, Matrícula: {Matricula}");
    }
}
