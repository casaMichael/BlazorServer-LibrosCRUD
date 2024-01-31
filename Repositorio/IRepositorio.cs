using BlazorServer_LibrosCRUD.Models;

namespace BlazorServer_LibrosCRUD.Repositorio
{
    public interface IRepositorio
    {
        public Task<List<Libro>>GetLibros();
        public Task<Libro> GetLibroId(int libroId);
        public Task<Libro> CrearLibro(Libro crearLibro);
        public Task<Libro> ActualizarLibro(int libroId,Libro actualizarLibro);
        public Task EliminarLibro(int libroId);
    }
}
