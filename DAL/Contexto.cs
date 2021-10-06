using Microsoft.EntityFrameworkCore;
using P1_ap1_josueosorio_20180938.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_ap1_josueosorio_20180938.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<AportesEntidades> AportesEntidades { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"DATA Source=DATA\Registroaportes.db");
        }
    }
}
