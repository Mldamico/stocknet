using Stocknet.Entities;

namespace Stocknet.Data;

public static class DbInitializer
{
    public static void Initialize(StoreContext storeContext)
    {
        if (storeContext.Products.Any()) return;

        var products = new List<Product>
        {
            new Product
            {
                Name = "Corpiño taza soft",
                Article = "4249",
                Price = 26550,
                Brand = "Selu",
                Type = "Corseteria",
                PictureUrl = ""
            },
            new Product
            {
                Name = "Corpiño taza soft",
                Article = "4249",
                Price = 26550,
                Brand = "Selu",
                Type = "Corseteria",
                PictureUrl = "/images/products/selu4249"
            },
            new Product
            {
                Name = "Corpiño strapless",
                Article = "4232",
                Price = 27350,
                Brand = "Selu",
                Type = "Corseteria",
                PictureUrl = "/images/products/selu4232"
            },
            new Product
            {
                Name = "PIJAMA REMERA Y SHORT \"OPEN YOUR HEART\"",
                Article = "PR10206",
                Price = 22550,
                Brand = "Promesse",
                Type = "Lenceria",
                PictureUrl = "/images/products/promesse10206"
            }
        };

        storeContext.Products.AddRange(products);

        storeContext.SaveChanges();

    }
}