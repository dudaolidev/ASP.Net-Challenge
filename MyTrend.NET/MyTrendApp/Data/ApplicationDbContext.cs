using Microsoft.EntityFrameworkCore;
using MyTrendApp.Models;

namespace MyTrendApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // DbSets representando as tabelas no banco de dados
        public DbSet<Avaliacao> Avaliacoes { get; set; }
        public DbSet<CategoriaProduto> Categorias { get; set; }
        public DbSet<Cor> Cores { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<PerfilUsuario> Perfis { get; set; }
        public DbSet<RecomendacaoLook> Recomendacoes { get; set; }
        public DbSet<FeedbackUsuario> Feedbacks { get; set; }
        public DbSet<Roupa> Roupas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuração global para nomes de tabelas e colunas
            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {
                var tableName = entity.GetTableName();
                if (tableName != null)
                {
                    entity.SetTableName(tableName.ToUpperInvariant());
                }

                foreach (var property in entity.GetProperties())
                {
                    var columnName = property.GetColumnName();
                    if (columnName != null)
                    {
                        property.SetColumnName(columnName.ToUpperInvariant());
                    }
                }
            }
        }
    }
}
