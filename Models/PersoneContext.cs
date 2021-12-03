
using Microsoft.EntityFrameworkCore;

namespace Santi.Federico._5H.Primaweb.Models
{
    public class PersoneContext: Microsoft.EntityFrameworkCore.DbContext
    {
        public Microsoft.EntityFrameworkCore.DbSet<Persona> Persone{ get; set; }

        protected override void OnConfiguring(Microsoft.EntityFrameworkCore.DbContextOptionsBuilder opzioni)
        {
            opzioni.UseSqlite("Data Source=dbPersone.db");
        }
    }
}