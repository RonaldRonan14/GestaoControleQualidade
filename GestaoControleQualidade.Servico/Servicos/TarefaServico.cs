using GestaoControleQualidade.Dominio.Entidades;
using GestaoControleQualidade.Infraestrutura.Repositorios;

namespace GestaoControleQualidade.Servico.Servicos;

public class TarefaServico
{
    private readonly TarefaRepositorio _tarefaRepositorio;

    public TarefaServico(TarefaRepositorio tarefaRepositorio)
    {
        _tarefaRepositorio = tarefaRepositorio;
    }

    public async Task<IEnumerable<Tarefa>> ConsultarTarefas()
    {
        return await _tarefaRepositorio.ConcultarTarefas();
    }

    public async Task<Tarefa?> ConsultarTarefaPorId(Guid tarefaId)
    {
        return await _tarefaRepositorio.ConsultarTarefaPorId(tarefaId);
    }

    public async Task<Tarefa> AdicionarTarefa(Tarefa tarefa)
    {
        return await _tarefaRepositorio.AdicionarTarefa(tarefa);
    }

    public async Task<Tarefa> AtualizarTarefa(Guid tarefaId, Tarefa tarefa)
    {
        return await _tarefaRepositorio.AtualizarTarefa(tarefaId, tarefa);
    }

    public async Task DeletarTarefa(Guid tarefaId)
    {
        await _tarefaRepositorio.DeletarTarefa(tarefaId);
    }
}
