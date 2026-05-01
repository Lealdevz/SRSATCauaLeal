namespace SRS;

public class Disciplina
{
    private int IdDisciplina { get; set; }
    private string Nome { get; set; }
    private List<Disciplina> Requisitos { get; set; }
}