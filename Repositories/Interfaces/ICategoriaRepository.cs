using Site_Venda_Lanche.Models;

namespace Site_Venda_Lanche.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}
