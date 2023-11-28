using Site_Venda_Lanche.Models;

namespace Site_Venda_Lanche.Repositories.Interfaces
{
    public interface ILancheRepository
    {
        IEnumerable<Lanche> Lanches { get; }
        IEnumerable<Lanche> LanchesPreferidos { get; }
        
        Lanche GetLancheById(int lancheId);
    }
}
