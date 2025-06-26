using GestaoControleQualidade.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace GestaoControleQualidade.Infraestrutura.Dados;

public class GestaoControleQualidadeDb : DbContext
{
    public GestaoControleQualidadeDb(DbContextOptions<GestaoControleQualidadeDb> options) : base(options) { }

    public DbSet<Tarefa> Tarefas { get; set; }
}
