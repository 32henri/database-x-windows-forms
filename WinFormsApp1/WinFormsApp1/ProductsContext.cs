using Microsoft.EntityFrameworkCore;


namespace WinFormsApp1;
public class ProductsContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source=products.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().HasData(
            new Category { CategoryId = 1, Name = "Water" },
            new Category { CategoryId = 2, Name = "Phone" },
            new Category { CategoryId = 3, Name = "Bird" },
            new Category { CategoryId = 4, Name = "Bread" });

        modelBuilder.Entity<Product>().HasData(
            new Product { ProductId = 1, CategoryId = 1, Name = "Aura" },
            new Product { ProductId = 2, CategoryId = 1, Name = "Saaremaa" },
            new Product { ProductId = 3, CategoryId = 1, Name = "Värska" },
            new Product { ProductId = 4, CategoryId = 1, Name = "Evian" },
            new Product { ProductId = 5, CategoryId = 1, Name = "Everest" },
            new Product { ProductId = 11, CategoryId = 2, Name = "Samsung" },
            new Product { ProductId = 12, CategoryId = 2, Name = "Blckbery" },
            new Product { ProductId = 13, CategoryId = 2, Name = "IPhone" },
            new Product { ProductId = 14, CategoryId = 2, Name = "Huawei" },
            new Product { ProductId = 15, CategoryId = 2, Name = "Xiaomi" },
            new Product { ProductId = 16, CategoryId = 2, Name = "Nokia" },
            new Product { ProductId = 17, CategoryId = 2, Name = "LG" },
            new Product { ProductId = 18, CategoryId = 2, Name = "Cat" },
            new Product { ProductId = 21, CategoryId = 3, Name = "Parrot" },
            new Product { ProductId = 22, CategoryId = 3, Name = "Owl" },
            new Product { ProductId = 23, CategoryId = 3, Name = "Crow" },
            new Product { ProductId = 24, CategoryId = 3, Name = "Tit" },
            new Product { ProductId = 25, CategoryId = 4, Name = "Swan" },
            new Product { ProductId = 26, CategoryId = 4, Name = "Blackbird" },
            new Product { ProductId = 27, CategoryId = 4, Name = "Tit" },
            new Product { ProductId = 28, CategoryId = 4, Name = "Focaccia" },
            new Product { ProductId = 29, CategoryId = 4, Name = "Malted" },
            new Product { ProductId = 30, CategoryId = 4, Name = "Sourdough" },
            new Product { ProductId = 31, CategoryId = 4, Name = "Corn" },
            new Product { ProductId = 32, CategoryId = 4, Name = "White" },
            new Product { ProductId = 33, CategoryId = 4, Name = "Soda" });
    }
}