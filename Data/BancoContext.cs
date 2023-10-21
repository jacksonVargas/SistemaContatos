using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SistemaContatos.Models;

namespace SistemaContatos.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options) {}

        public DbSet<ContatoModel> contatos { get; set; }
    }
}