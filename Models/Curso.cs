namespace WebCursos.Models
{
    public class Curso
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = null!;
        public string? Descripcion { get; set; }
        public string? Categoria { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;

        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; } = null!;

        public ICollection<Material> Materiales { get; set; } = new List<Material>();
        public ICollection<Comentario> Comentarios { get; set; } = new List<Comentario>();
    }
}
