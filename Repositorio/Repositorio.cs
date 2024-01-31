using BlazorServer_LibrosCRUD.Data;
using BlazorServer_LibrosCRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorServer_LibrosCRUD.Repositorio
{
    public class Repositorio : IRepositorio
    {

        private readonly AplicationDbContext _contexto;

        public Repositorio(AplicationDbContext contexto)
        {
            _contexto = contexto;
        }

        public async Task<Libro> ActualizarLibro(int libroId, Libro actualizarLibro)
        {
            var librodesdeBD = await _contexto.Libro.FindAsync(libroId);
            librodesdeBD.Titulo = actualizarLibro.Titulo;
            librodesdeBD.Descripcion = actualizarLibro.Descripcion;
            librodesdeBD.Autor = actualizarLibro.Autor;
            librodesdeBD.Paginas = actualizarLibro.Paginas;
            librodesdeBD.Precio = actualizarLibro.Precio;

            await _contexto.SaveChangesAsync();
            return librodesdeBD;
        }

        public async Task<Libro> CrearLibro(Libro crearLibro)
        {
            if(crearLibro != null)
            { 
                crearLibro.FechaCreacion = DateTime.Now;
                await _contexto.Libro.AddAsync(crearLibro);
                await _contexto.SaveChangesAsync();
                return crearLibro;
            }
            else
            {
                return new Libro();
            }
        }

        public async Task EliminarLibro(int libroId)
        {
            var librodesdeBD = await _contexto.Libro.FindAsync(libroId);
            _contexto.Remove(librodesdeBD);
            await _contexto.SaveChangesAsync();
        }

        public async Task<Libro> GetLibroId(int libroId)
        {
            var librodesdeBD = await _contexto.Libro.FindAsync(libroId);
            if (librodesdeBD == null)
            {
                return new Libro();
            }
            return librodesdeBD;
        }

        public Task<List<Libro>> GetLibros()
        {
            return _contexto.Libro.ToListAsync();
        }
    }
}
