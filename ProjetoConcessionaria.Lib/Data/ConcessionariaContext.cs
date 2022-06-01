using Microsoft.EntityFrameworkCore;
using ProjetoConcessionaria.Lib.Models;

namespace ProjetoConcessionaria.Lib.Data
{
    public class ConcessionariaContext : DbContext
    {
        public ConcessionariaContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //mapeando tabelas
            //Clientes
            modelBuilder.Entity<Cliente>().ToTable("conc_clientes");
            modelBuilder.Entity<Cliente>().HasKey(key => key.Id);
            modelBuilder.Entity<Cliente>()
                        .HasMany(cliente => cliente.Compras)
                        .WithOne(compras => compras.GetComprador())
                        .HasForeignKey(x => x.IdCliente);

            //Funcionarios
            modelBuilder.Entity<Funcionario>().ToTable("conc_funcionarios");
            modelBuilder.Entity<Funcionario>().HasKey(key => key.Id);
            modelBuilder.Entity<Funcionario>().HasMany(funcionario => funcionario.Vendas)
                                              .WithOne(vendas => vendas.GetVendedor())
                                              .HasForeignKey(x => x.IdFuncionario);

            //Carros
            modelBuilder.Entity<Carro>().ToTable("conc_carros");
            modelBuilder.Entity<Carro>().HasKey(key => key.Id); //Indica a propriedade da chave primaria, no caso Id
            modelBuilder.Entity<Carro>()
                        .HasOne(x => x.Venda) //Indica a propriedade do relacionamento One = 1 Many = N
                        .WithOne(x => x.Carro)
                        .HasForeignKey<Carro>(x => x.IdVenda);

            //Motos
            modelBuilder.Entity<Moto>().ToTable("conc_motos");
            modelBuilder.Entity<Moto>().HasKey(key => key.Id);
            modelBuilder.Entity<Moto>().HasOne(x => x.Venda)
                                       .WithOne(x => x.Moto)
                                       .HasForeignKey<Moto>(x => x.IdVenda);

            //Vendas
            modelBuilder.Entity<Venda>().ToTable("conc_vendas");

        }
        public DbSet<Carro> Carros { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Moto> Motos { get; set; }
        public DbSet<Venda> Vendas { get; set; }
    }
}