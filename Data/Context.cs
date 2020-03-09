using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TW03.Models;

namespace TW03.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }

        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<Inscricao> Inscricoes { get; set; }
        public DbSet<Aula> Aulas { get; set; }
        public DbSet<Academia> Academias { get; set; }
        public DbSet<Professor> Professores { get; set; }
        public DbSet<Graduacao> Graduacoes { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Contato> Contatos { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Pagamento> Pagamentos { get; set; }
        public DbSet<Bolsa> Bolsas { get; set; }
        public DbSet<Ensinar> Ensina { get; set; }
        public DbSet<ImagemPessoa> Imagens { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aula>().ToTable("Aula");
            modelBuilder.Entity<Inscricao>().ToTable("Inscricao");
            modelBuilder.Entity<Aluno>().ToTable("Aluno");
            modelBuilder.Entity<Academia>().ToTable("Academia");
            modelBuilder.Entity<Bolsa>().ToTable("Bolsa");
            modelBuilder.Entity<Categoria>().ToTable("Categoria");
            modelBuilder.Entity<Contato>().ToTable("Contato");
            modelBuilder.Entity<Ensinar>().ToTable("Ensinar");
            modelBuilder.Entity<Graduacao>().ToTable("Graduacao");
            modelBuilder.Entity<ImagemPessoa>().ToTable("ImagemPessoa");
            modelBuilder.Entity<Pagamento>().ToTable("Pagamento");
            modelBuilder.Entity<Pessoa>().ToTable("Pessoa");
            modelBuilder.Entity<Professor>().ToTable("Professor");
        }
    }
}
