using System.ComponentModel;

namespace GestaoControleQualidade.Dominio.Enumerados;

public enum StatusTarefa
{
    [Description("A Fazer")]
    AFazer = 1,

    [Description("Em Progresso")]
    EmProgresso = 2,

    [Description("Concluído")]
    Concluido = 3
}
