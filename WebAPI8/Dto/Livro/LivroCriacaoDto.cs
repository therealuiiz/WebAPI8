using WebAPI8.Models;

namespace WebAPI8.Dto.Livro
{
    public class LivroCriacaoDto
    {
        public string Titulo { get; set; }
        public AutorModel Autor { get; set; }
    }
}
