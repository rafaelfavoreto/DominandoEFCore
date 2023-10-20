using System;
using Curso.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Curso.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Departamento> Departamentos {get;set;}
        public DbSet<Funcionario> Funcionarios {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            const string strConnection= "Data source=Local\\DBFavoreto; Initial Catalog=DBSenaiLondrina;Integrated Security=True;polling=true";

            optionsBuilder.UseSqlServer(strConnection)
                .EnableSensitiveDataLogging()               
                .LogTo(Console.WriteLine,LogLevel.Information)
                .EnableSensitiveDataLogging()
                .AddInterceptors(new Interceptadores.InterceptadorDeComandos())
                .AddInterceptors(new Interceptadores.interceptadorDeConexao())
                .AddInterceptors(new Interceptadores.InterceptadorPersistencia());        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Codificação de criaçãos das model 
        }

    }
}