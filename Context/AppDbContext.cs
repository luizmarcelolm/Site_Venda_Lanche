﻿using Microsoft.EntityFrameworkCore;
using Site_Venda_Lanche.Models;

namespace Site_Venda_Lanche.Context
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{
		}
		public DbSet<Categoria> Categorias { get; set; }
		public DbSet<Lanche> Lanches { get; set; }
		public DbSet<CarrinhoCompraItem> CarrinhoCompraItens { get; set; }

        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<PedidoDetalhe> PedidoDetalhes { get; set; }
    }
}