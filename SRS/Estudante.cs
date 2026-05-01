namespace SRS;

public class Estudante
{
    private int IdEstudante { get; set; }
    private string Nome { get; set; }
    private string Email { get; set; }
    private Professor Orientador { get; set; }
    private PlanoDeEstudo PlanoEstudo { get; set; }
    private string Historico { get; set; }
}