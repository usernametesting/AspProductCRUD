namespace AspMvcFirstTask.MyDb
{
    public static class ProductDb
    {
        public static List<Product> products = new List<Product>
        {
            new Product { Id = Guid.NewGuid(), Name = "Product 1", Description = "Description for product 1", Price = 10.50m, Category = "Category 1" },
            new Product { Id = Guid.NewGuid(), Name = "Product 2", Description = "Description for product 2", Price = 15.75m, Category = "Category 2" },
            new Product { Id = Guid.NewGuid(), Name = "Product 3", Description = "Description for product 3", Price = 20.00m, Category = "Category 3" },
            new Product { Id = Guid.NewGuid(), Name = "Product 4", Description = "Description for product 4", Price = 25.25m, Category = "Category 4" },
            new Product { Id = Guid.NewGuid(), Name = "Product 5", Description = "Description for product 5", Price = 30.50m, Category = "Category 5" },
            new Product { Id = Guid.NewGuid(), Name = "Product 6", Description = "Description for product 6", Price = 35.75m, Category = "Category 1" },
            new Product { Id = Guid.NewGuid(), Name = "Product 7", Description = "Description for product 7", Price = 40.00m, Category = "Category 2" },
            new Product { Id = Guid.NewGuid(), Name = "Product 8", Description = "Description for product 8", Price = 45.25m, Category = "Category 3" },
            new Product { Id = Guid.NewGuid(), Name = "Product 9", Description = "Description for product 9", Price = 50.50m, Category = "Category 4" },
            new Product { Id = Guid.NewGuid(), Name = "Product 10", Description = "Description for product 10", Price = 55.75m, Category = "Category 5" },
            new Product { Id = Guid.NewGuid(), Name = "Product 11", Description = "Description for product 11", Price = 60.00m, Category = "Category 1" },
            new Product { Id = Guid.NewGuid(), Name = "Product 12", Description = "Description for product 12", Price = 65.25m, Category = "Category 2" },
            new Product { Id = Guid.NewGuid(), Name = "Product 13", Description = "Description for product 13", Price = 70.50m, Category = "Category 3" },
            new Product { Id = Guid.NewGuid(), Name = "Product 14", Description = "Description for product 14", Price = 75.75m, Category = "Category 4" },
            new Product { Id = Guid.NewGuid(), Name = "Product 15", Description = "Description for product 15", Price = 80.00m, Category = "Category 5" },
            new Product { Id = Guid.NewGuid(), Name = "Product 16", Description = "Description for product 16", Price = 85.25m, Category = "Category 1" },
            new Product { Id = Guid.NewGuid(), Name = "Product 17", Description = "Description for product 17", Price = 90.50m, Category = "Category 2" },
            new Product { Id = Guid.NewGuid(), Name = "Product 18", Description = "Description for product 18", Price = 95.75m, Category = "Category 3" },
            new Product { Id = Guid.NewGuid(), Name = "Product 19", Description = "Description for product 19", Price = 100.00m, Category = "Category 4" },
            new Product { Id = Guid.NewGuid(), Name = "Product 20", Description = "Description for product 20", Price = 105.25m, Category = "Category 5" }
        };
    }

}
