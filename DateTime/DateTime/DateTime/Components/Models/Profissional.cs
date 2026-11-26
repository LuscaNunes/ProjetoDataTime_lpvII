namespace DateTime.Models;

using System.ComponentModel.DataAnnotations;

public class Profissional
{
    public int Id { get; set; }

    [Required(ErrorMessage = "O nome é obrigatório")]
    [StringLength(100, MinimumLength = 3, ErrorMessage = "O nome deve ter entre 3 e 100 caracteres")]
    public string Nome { get; set; } = "";

    [Required(ErrorMessage = "A especialidade é obrigatória")]
    [StringLength(60, ErrorMessage = "A especialidade deve ter no máximo 60 caracteres")]
    public string Especialidade { get; set; } = "";

    // Um profissional pode ter vários agendamentos
    public List<Agendamento> Agendamentos { get; set; } = new();
}