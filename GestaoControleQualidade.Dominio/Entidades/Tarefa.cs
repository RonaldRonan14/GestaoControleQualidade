using GestaoControleQualidade.Dominio.Enumerados;
using System.ComponentModel.DataAnnotations;

namespace GestaoControleQualidade.Dominio.Entidades;

public class Tarefa
{
    [Key]
    public Guid TarefaId { get; set; }

    [Required]
    [MaxLength(100)]
    public string Titulo { get; set; }

    [MaxLength(500)]
    public string Descricao { get; set; }

    [Required]
    public StatusTarefa StatusTarefa { get; set; }

    [Required]
    public DateTime DataCriacao { get; set; } = DateTime.Now;

    public DateTime DataAlteracao { get; set; }

    public DateTime? DataVencimento { get; set; }
}
