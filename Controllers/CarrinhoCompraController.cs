using Microsoft.AspNetCore.Mvc;
using Site_Venda_Lanche.Models;
using Site_Venda_Lanche.Repositories.Interfaces;
using Site_Venda_Lanche.ViewModels;
using System.Runtime.CompilerServices;

namespace Site_Venda_Lanche.Controllers
{
	public class CarrinhoCompraController : Controller
	{
		private readonly ILancheRepository _lancheRepository;
	    private readonly CarrinhoCompra _carrinhoCompra;

		public CarrinhoCompraController(ILancheRepository lancheRepository, CarrinhoCompra carrinhoCompra)
		{
			_lancheRepository = lancheRepository;
			_carrinhoCompra = carrinhoCompra;
		}

		public IActionResult Index()
		{
			var itens = _carrinhoCompra.GetCarrinhoCompraItens();
			_carrinhoCompra.CarrinhoCompraItens = itens;

			var carrinhoCompraVM = new CarrinhoCompraViewModel
			{
				CarrinhoCompra = _carrinhoCompra,
				CarrinhoCompraTotal = _carrinhoCompra.GetCarrinhoCompraTotal()
			};

			return View(carrinhoCompraVM);
		}

		public IActionResult AdicionarItemNoCarrinhoCompra(int lancheId)
		{
			var lancheSelecionado = _lancheRepository.Lanches
				.FirstOrDefault(p => p.LancheId == lancheId);	
			if(lancheSelecionado != null)
			{
				_carrinhoCompra.AdivionarAoCarrinho(lancheSelecionado);
			}
			return RedirectToAction("Index");
		}

		public IActionResult RemoveItemDoCarrinhoCompra(int lancheId)
		{
			var lancheSelecionado = _lancheRepository.Lanches
				.FirstOrDefault(p => p.LancheId == lancheId);
			if (lancheSelecionado != null)
			{
				_carrinhoCompra.RemoverDoCarrinho(lancheSelecionado);
			}
			return RedirectToAction("Index");

		}

	}
}
