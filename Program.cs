namespace Site_Venda_Lanche;

public class Program
{
    public static void Main(string[] args)
    {
        CreateHostBuilder(args)
           .Build()
           .Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });
}