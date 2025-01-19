namespace WebCursos.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Email { get; set; } = null!;
        public string PasswordHash { get; set; } = null!;
        public string Rol { get; set; } = "Estudiante"; // Estudiante, Instructor, Admin
        public DateTime FechaRegistro { get; set; } = DateTime.UtcNow;

        public ICollection<Curso> Cursos { get; set; } = new List<Curso>();
        public ICollection<Comentario> Comentarios { get; set; } = new List<Comentario>();
    }
}
