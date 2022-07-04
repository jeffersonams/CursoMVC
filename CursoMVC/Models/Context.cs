using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVC.Models
{
    public class Context : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }//VAI TER UMA TABELA NO BD CHAMADA Categorias
        public DbSet<Produto> Produtos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)//METODOS RESPONSAVEL POR CONFIGURAR O ENTITY FRAMEWORK - E FALAR QUAL BD QUE VAI ULTILIZAR
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=(localdb)\mssqllocaldb;Database=Cursomvc;Integrated Security=true");
        }
    }
}
