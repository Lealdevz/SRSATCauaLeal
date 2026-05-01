namespace SRS;

public class Turma
{
    private int IdTurma { get; set; }
    private Disciplina MateriaTurma { get; set; }
    private Professor ProfessorTurma { get; set; }
    private string DiaDaAula { get; set; }
    private string Horario { get; set; }
    private int CapacidadeDaTurma { get; set; }
    private List<Estudante> Estudantes { get; set; }
}