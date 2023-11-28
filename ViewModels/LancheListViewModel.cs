using Site_Venda_Lanche.Models;

namespace Site_Venda_Lanche.ViewModels
{
	public class LancheListViewModel
	{
		public IEnumerable<Lanche> Lanches { get; set; }

		public string CategoriaAtual { get; set; }
	}
}
