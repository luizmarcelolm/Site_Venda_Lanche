using Site_Venda_Lanche.Context;
using Site_Venda_Lanche.Models;
using Site_Venda_Lanche.Repositories.Interfaces;

namespace Site_Venda_Lanche.Repositories
{
	public class CategoriaRepository : ICategoriaRepository
	{
		private readonly AppDbContext _context;

		public CategoriaRepository(AppDbContext context)
		{
			_context = context;
		}

		public IEnumerable<Categoria> Categorias => _context.Categorias;
	}
}
