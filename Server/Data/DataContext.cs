using BlazorEcommerce.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazorEcommerce.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                    new Product
                    {
                        Id = 1,
                        Title = "Tron",
                        Description = "Prodotto dalla Disney, è considerato un film culto e vede come protagonisti Bruce Boxleitner, Jeff Bridges, David Warner e Cindy Morgan. È anche considerato il primo film di fantascienza a focalizzarsi sulla realtà virtuale. Ha uno stile visivo unico e assolutamente all'avanguardia per l'epoca. È il primo film della Disney a fare grande uso della computer grafica.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/it/1/1d/Tron1982.png",
                        Price = 9.99m
                    },
                    new Product
                    {
                        Id = 2,
                        Title = "Wargames - Giochi di guerra",
                        Description = "Presentato fuori concorso al 36º Festival di Cannes,[1] il film propone temi e argomenti tipici dei primi anni ottanta caratterizzati dalla corsa agli armamenti, dallo stallo degli accordi SALT e dal dispiegamento degli euromissili secondo una prospettiva progressista e pacifista. La morale del film si basa sul concetto di distruzione mutua assicurata.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/it/2/29/Wargames.jpg",
                        Price = 9.99m
                    },
                    new Product
                    {
                        Id = 3,
                        Title = "Corto circuito",
                        Description = "è un film di fantascienza del 1986 diretto da John Badham, con protagonisti Ally Sheedy e Steve Guttenberg.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/it/1/16/Corto_circuito_%28film%29.png",
                        Price = 9.99m
                    }
            );
            
        }

        public DbSet<Product> Products { get; set; }
    }
}
