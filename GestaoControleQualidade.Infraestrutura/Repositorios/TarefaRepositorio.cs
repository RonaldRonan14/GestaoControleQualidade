using GestaoControleQualidade.Dominio.Entidades;
using GestaoControleQualidade.Dominio.Enumerados;
using GestaoControleQualidade.Infraestrutura.Dados;
using Microsoft.EntityFrameworkCore;

namespace GestaoControleQualidade.Infraestrutura.Repositorios;

public class TarefaRepositorio
{
    private readonly GestaoControleQualidadeDb _context;

    public TarefaRepositorio(GestaoControleQualidadeDb context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Tarefa>> ConcultarTarefas()
    {
        return await _context.Tarefas
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task<Tarefa?> ConsultarTarefaPorId(Guid tarefaId)
    {
        return await _context.Tarefas
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.TarefaId == tarefaId);
    }

    public async Task<Tarefa> AdicionarTarefa(Tarefa tarefa)
    {
        _context.Tarefas.Add(tarefa);
        await _context.SaveChangesAsync();

        return tarefa;
    }

    public async Task<Tarefa> AtualizarTarefa(Guid tarefaId, Tarefa tarefa)
    {
        var tarefaEntidade = await _context.Tarefas
            .FirstOrDefaultAsync(t => t.TarefaId == tarefaId);

        if (tarefaEntidade == null)
            throw new KeyNotFoundException();

        tarefaEntidade.Titulo = tarefa.Titulo;
        tarefaEntidade.Descricao = tarefa.Descricao;
        tarefaEntidade.StatusTarefa = tarefa.StatusTarefa;
        tarefaEntidade.DataAlteracao = DateTime.Now;
        tarefaEntidade.DataVencimento = tarefa.DataVencimento;

        await _context.SaveChangesAsync();

        return tarefaEntidade;
    }

    public async Task<Tarefa> AtualizarStatusTarefa(Guid tarefaId, StatusTarefa statusTarefa)
    {
        var tarefaEntidade = await _context.Tarefas
            .FirstOrDefaultAsync(t => t.TarefaId == tarefaId);

        if (tarefaEntidade == null)
            throw new KeyNotFoundException();

        tarefaEntidade.StatusTarefa = statusTarefa;
        tarefaEntidade.DataAlteracao = DateTime.Now;

        await _context.SaveChangesAsync();

        return tarefaEntidade;
    }

    public async Task DeletarTarefa(Guid tarefaId)
    {
        var tarefaEntidade = await _context.Tarefas
            .FirstOrDefaultAsync(t => t.TarefaId == tarefaId);

        if (tarefaEntidade == null)
            throw new KeyNotFoundException();

        _context.Tarefas.Remove(tarefaEntidade);
        await _context.SaveChangesAsync();
    }
}
