using AutoMapper;
using GestaoControleQualidade.Dominio.Entidades;
using GestaoControleQualidade.Servico.Dtos;

namespace GestaoControleQualidade.Servico.Perfis;

public class TarefaPerfil : Profile
{
    public TarefaPerfil()
    {
        CreateMap<Tarefa, TarefaDto>();
        CreateMap<Tarefa, AtualizarTarefaDto>();
        CreateMap<AdicionarTarefaDto, Tarefa>();
        CreateMap<AtualizarTarefaDto, Tarefa>();
    }
}
