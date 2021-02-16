using EFCore.WebAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.WebAPI.Data
{
    public class PessoaContext : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Dependente> Dependentes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Password=Abcdef1234;Persist Security Info=True;User ID=sa;Initial Catalog=DbProject;Data Source=127.0.0.1");
        }
    }
}
