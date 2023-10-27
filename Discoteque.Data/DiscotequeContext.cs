using Microsoft.EntityFrameworkCore;
using Discoteque.Data.Models;
namespace Discoteque.Data;

public class DiscotequeContext : DbContext
//using es como una libreria y DbContext la usamos de alli
{
    public DiscotequeContext(DbContextOptions<DiscotequeContext> options) : base(options)
    //usa la libreria baseentity cuando llama base option
        {

        }

    public DbSet<Artist> Artists { get; set; }
    //DbSet se refiere a la cracion de una tabla y el Artists en pural es por que es una lista 
    public DbSet<Album> Albums { get; set; }

}