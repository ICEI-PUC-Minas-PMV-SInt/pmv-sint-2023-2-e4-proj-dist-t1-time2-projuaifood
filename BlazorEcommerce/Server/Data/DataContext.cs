namespace BlazorEcommerce.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Frutas",
                    Url = "frutas"
                },
                new Category
                {
                    Id = 2,
                    Name = "Verduras",
                    Url = "verduras"
                },
                new Category
                {
                    Id = 3,
                    Name = "Legumes",
                    Url = "legumes"
                }
            );

            modelBuilder.Entity<Product>().HasData(
                 new Product
                 {
                     Id = 1,
                     Name = "Abacaxi",
                     Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum tristique in lacus in eleifend. Aenean vitae hendrerit metus. Donec vestibulum dui sed est fermentum efficitur.",
                     ImageUrl = "https://images.unsplash.com/photo-1550258987-190a2d41a8ba?q=80&w=1887&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                     Price = 3.99m,
                     CategoryId = 1
                 },
                new Product
                {
                    Id = 2,
                    Name = "Laranja",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum tristique in lacus in eleifend. Aenean vitae hendrerit metus. Donec vestibulum dui sed est fermentum efficitur.",
                    ImageUrl = "https://plus.unsplash.com/premium_photo-1671013032586-3e9a5c49ce3c?q=80&w=1887&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                    Price = 1.99m,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 3,
                    Name = "Abacate",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum tristique in lacus in eleifend. Aenean vitae hendrerit metus. Donec vestibulum dui sed est fermentum efficitur.",
                    ImageUrl = "https://plus.unsplash.com/premium_photo-1675715402461-9ac75a5b400e?q=80&w=1887&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                    Price = 2.99m,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 4,
                    Name = "Alface",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum tristique in lacus in eleifend. Aenean vitae hendrerit metus. Donec vestibulum dui sed est fermentum efficitur.",
                    ImageUrl = "https://plus.unsplash.com/premium_photo-1674666545272-fa8f4acfc99b?q=80&w=1887&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                    Price = 0.99m,
                    CategoryId = 2
                },
                new Product
                {
                    Id = 5,
                    Name = "Abóbora",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum tristique in lacus in eleifend. Aenean vitae hendrerit metus. Donec vestibulum dui sed est fermentum efficitur.",
                    ImageUrl = "https://images.unsplash.com/photo-1510239204303-938e5bf9ebbf?q=80&w=1887&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                    Price = 5.50m,
                    CategoryId = 3
                },
                new Product
                {
                    Id = 6,
                    Name = "Espinafre",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum tristique in lacus in eleifend. Aenean vitae hendrerit metus. Donec vestibulum dui sed est fermentum efficitur.",
                    ImageUrl = "https://images.unsplash.com/photo-1550411294-875307bccdd5?q=80&w=1887&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                    Price = 1.99m,
                    CategoryId = 2
                },
                new Product
                {
                    Id = 7,
                    Name = "Uva",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum tristique in lacus in eleifend. Aenean vitae hendrerit metus. Donec vestibulum dui sed est fermentum efficitur.",
                    ImageUrl = "https://images.unsplash.com/photo-1601275868399-45bec4f4cd9d?q=80&w=1935&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                    Price = 1.70m,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 8,
                    Name = "Cenoura",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum tristique in lacus in eleifend. Aenean vitae hendrerit metus. Donec vestibulum dui sed est fermentum efficitur.",
                    ImageUrl = "https://images.unsplash.com/photo-1598170845058-32b9d6a5da37?q=80&w=1887&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                    Price = 1.99m,
                    CategoryId = 3
                }
            );
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
