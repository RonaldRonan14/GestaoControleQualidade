using GestaoControleQualidade.Dominio.Enumerados;
using System.ComponentModel.DataAnnotations;

namespace GestaoControleQualidade.Servico.Dtos;

public class TarefaDto
{
    public Guid TarefaId { get; set; }
    public string Titulo { get; set; }
    public string Descricao { get; set; }
    public StatusTarefa StatusTarefa { get; set; }
    public DateTime DataCriacao { get; set; }
    public DateTime DataAlteracao { get; set; }
    public DateTime? DataVencimento { get; set; }
}

public class AdicionarTarefaDto
{
    [Required(ErrorMessage = "O título é obrigatório.")]
    [MaxLength(100, ErrorMessage = "O título não pode ter mais de 100 caracteres.")]
    public string Titulo { get; set; } = string.Empty;

    [MaxLength(500, ErrorMessage = "A descrição não pode ter mais de 500 caracteres.")]
    public string Descricao { get; set; } = string.Empty;

    [Required(ErrorMessage = "O status da tarefa é obrigatório.")]
    public StatusTarefa StatusTarefa { get; set; }

    public DateTime? DataVencimento { get; set; }
}

public class AtualizarTarefaDto
{
    [Required]
    [MaxLength(100)]
    public string Titulo { get; set; }

    [MaxLength(500)]
    public string Descricao { get; set; }

    [Required]
    public StatusTarefa StatusTarefa { get; set; }

    public DateTime? DataVencimento { get; set; }
}
