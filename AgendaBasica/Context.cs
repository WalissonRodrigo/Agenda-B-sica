using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaBasica
{
    public class Context : DbContext
    {
        public Context() : base("name=Agenda")
        {

        }
        public DbSet<Contato> Contatos { get; set; }
    }
}
