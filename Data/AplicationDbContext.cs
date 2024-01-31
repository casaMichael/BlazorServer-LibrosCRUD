
using BlazorServer_LibrosCRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorServer_LibrosCRUD.Data
{
    public class AplicationDbContext:DbContext
    {

        public AplicationDbContext(DbContextOptions<AplicationDbContext>options):base(options)
        {

        }

        //Colocamos cada uno de los modelos
        public DbSet<Libro> Libro { get; set; }



    }
}
