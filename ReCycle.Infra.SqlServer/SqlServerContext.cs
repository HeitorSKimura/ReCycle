using Microsoft.EntityFrameworkCore;
using ReCycle.Domain.CadastroContext;
using ReCycle.Domain.ConfigContext;
using ReCycle.Domain.EnderecoContext;
using ReCycle.Domain.MapaColetaContext;
using ReCycle.Domain.TrocaPontuacaoContext;
using ReCycle.Domain.UserManagementContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCycle.Infra.SqlServer
{
    public class SqlServerContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ReCycle");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().UseTpcMappingStrategy();

            // 1..* User tem 0..* Endereco      -----> Muitos para muitos
            modelBuilder.Entity<User>()
                .HasMany(e => e.Endereco)
                .WithMany(e => e.User)
                .UsingEntity<UserEndereco>();

            // 0..1 loja tem 0..* endereco      -----> Um para muitos
            modelBuilder.Entity<Loja>()
                .HasMany(e => e.Enderecos)
                .WithOne(e => e.Loja)
                .HasForeignKey(e => e.LojaId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(false);

            // 1..1 Loja tem 0..* Cupom         -----> Um para muitos
            modelBuilder.Entity<Loja>()
                .HasMany(e => e.Cupons)
                .WithOne(e => e.Loja)
                .HasForeignKey(e => e.LojaId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            // 0..* Cupom tem 0..* Pontuacao    -----> Muitos para muitos
            modelBuilder.Entity<Cupom>()
                .HasMany(e => e.Pontuacoes)
                .WithMany(e => e.Cupons)
                .UsingEntity<PontuacaoCupom>();

            // 1..1 Config tem 0..* Pontuacao   -----> Um para muitos
            modelBuilder.Entity<Config>()
                .HasMany(e => e.Pontuacoes)
                .WithOne(e => e.Config)
                .HasForeignKey(e => e.ConfigId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            // 1..1 Admin tem 0..* Config       -----> Um para muitos
            modelBuilder.Entity<Admin>()
                .HasMany(e => e.Configs)
                .WithOne(e => e.Admin)
                .HasForeignKey(e => e.UserId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            // 1..1 Config tem 0..* AreaColeta  -----> Um para muitos
            modelBuilder.Entity<Config>()
                .HasMany(e => e.AreasColeta)
                .WithOne(e => e.Config)
                .HasForeignKey(e => e.ConfigId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            // 0..1 Coletor tem 0..1 AreaColeta -----> Um para um
            modelBuilder.Entity<Coletor>()
                .HasOne(e => e.AreasColeta)
                .WithOne(e => e.Coletor)
                .HasForeignKey<AreaColeta>(e => e.UserId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(false);

            // 1..1 AreaColeta tem 0..* PontoColeta -----> Um para muitos
            modelBuilder.Entity<AreaColeta>()
                .HasMany(e => e.PontosColeta)
                .WithOne(e => e.AreaColeta)
                .HasForeignKey(e => e.AreaColetaId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            // 1..1 Endereco tera 0..1 PontoColeta  -----> Um para muitos
            modelBuilder.Entity<Endereco>()
                .HasMany(e => e.PontosColeta)
                .WithOne(e => e.Endereco)
                .HasForeignKey(e => e.EnderecoId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            // 1.1 Descartante tem 0..* Pontuacao   -----> Um para muitos
            modelBuilder.Entity<Descartante>()
                .HasMany(e => e.Pontuacoes)
                .WithOne(e => e.Descartante)
                .HasForeignKey(e => e.DescartanteId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            // 1.1 PontoColeta tem 0..* Pontuacao   -----> Um para muitos
            modelBuilder.Entity<PontoColeta>()
                .HasMany(e => e.Pontuacoes)
                .WithOne(e => e.PontoColeta)
                .HasForeignKey(e => e.PontoColetaId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();
        }

        //Admin Context
        public DbSet<Config> Configs { get; set; }
        //CadastroContext
        public DbSet<User> Users { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Coletor> Coletores { get; set; }
        public DbSet<Descartante> Descartantes { get; set; }
        public DbSet<Loja> Lojas { get; set; }
        //EnderecoContext
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<UserEndereco> UserEnderecos { get; set; }
        //MapaColetaContext
        public DbSet<AreaColeta> AreasColeta { get; set; }
        public DbSet<PontoColeta> PontosColeta { get; set; }
        //TrocaPontuacaoContext
        public DbSet<Cupom> Cupons { get; set; }
        public DbSet<Pontuacao> Pontuacoes { get; set; }
        public DbSet<PontuacaoCupom> PontuacoesCupom { get; set; }
    }
}
