namespace WebCursos.Models
{
    public class Comentario
    {
        public int Id { get; set; }
        public int CursoId { get; set; }
        public Curso Curso { get; set; } = null!;
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; } = null!;
        public string Texto { get; set; } = null!;
        public DateTime Fecha { get; set; } = DateTime.UtcNow;
    }
}
