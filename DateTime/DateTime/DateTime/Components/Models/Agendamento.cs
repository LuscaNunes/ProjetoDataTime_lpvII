using System.ComponentModel.DataAnnotations;

namespace DateTime.Models;

public class Agendamento
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Informe a data e hora")]
    public System.DateTime DataHora { get; set; } = System.DateTime.Now;

    [Required(ErrorMessage = "Informe o serviço")]
    [StringLength(100, ErrorMessage = "O serviço deve ter no máximo 100 caracteres")]
    public string Servico { get; set; } = "";

    public string Status { get; set; } = "Agendado";

    [Range(1, int.MaxValue, ErrorMessage = "Selecione um cliente")]
    public int ClienteId { get; set; }
    public Cliente? Cliente { get; set; }

    [Range(1, int.MaxValue, ErrorMessage = "Selecione um profissional")]
    public int ProfissionalId { get; set; }
    public Profissional? Profissional { get; set; }
}