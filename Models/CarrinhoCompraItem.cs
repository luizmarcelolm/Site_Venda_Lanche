﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Site_Venda_Lanche.Models
{
	[Table("CarrinhoCompraItens")]
	public class CarrinhoCompraItem
	{
		public int CarrinhoCompraItemID { get; set; }
		public Lanche Lanche { get; set; }
		public int Quantidade { get; set; }

		[StringLength(200)]
		public string CarrinhoCompraId { get; set; }	
	}
}
