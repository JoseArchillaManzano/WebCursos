namespace WebCursos.Models
{
    public class Material
    {
        public int Id { get; set; }
        public int CursoId { get; set; }
        public Curso Curso { get; set; } = null!;
        public string Tipo { get; set; } = null!; // Ejemplo: "Video", "PDF"
        public string URL { get; set; } = null!;
    }
}
