using WebAPI8.Dto.Vinculo;
using WebAPI8.Models;

namespace WebAPI8.Dto.Livro
{
    public class LivroCriacaoDto
    {
        public string Titulo { get; set; }
        public AutorVinculoDto Autor { get; set; }
    }
}
