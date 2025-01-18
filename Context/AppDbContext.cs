using CadastrarFuncionariosMVC.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CadastrarFuncionariosMVC.Context
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
       

        //TABELA DE FUNCIONÁRIOS.
        public DbSet<Funcionarios> Funcionarios { get; set; }






    }
}
