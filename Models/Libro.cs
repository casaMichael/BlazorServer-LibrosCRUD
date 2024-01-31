using System.ComponentModel.DataAnnotations;

namespace BlazorServer_LibrosCRUD.Models
{
    public class Libro
    {//Llave primaria incrementable

        [Key] 
        public int IDLibro { get; set; }
        [Required(ErrorMessage ="EL Título es obligatorio")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "Descripcion obligatoria")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "Autor obligatorio")]
        public string Autor { get; set; }
        [Required(ErrorMessage = "Cantidad obligatoria")]
        public int Paginas { get; set; }
        [Required(ErrorMessage = "EL Precio es obligatorio")]
        public int Precio { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
