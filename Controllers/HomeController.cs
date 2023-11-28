﻿using Microsoft.AspNetCore.Mvc;
using Site_Venda_Lanche.Models;
using Site_Venda_Lanche.Repositories.Interfaces;
using Site_Venda_Lanche.ViewModels;
using System.Diagnostics;

namespace Site_Venda_Lanche.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILancheRepository _lancheRepository;

		public HomeController(ILancheRepository lancheRepository)
		{
			_lancheRepository = lancheRepository;
		}

		public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                LanchePreferidos = _lancheRepository.LanchesPreferidos
            };
            return View(homeViewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}