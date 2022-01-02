using Ex6.Models;
using System.Collections.Generic;
using System.Linq;

namespace Ex6.Services
{
    public class ProductService
    {
        private static List<Product> Products = new List<Product>
        {
            new Product
            {
                Id =1,
                Name = "Długopis automatyczny",
                Description = "Długopis z wymiennym wkładem żelowym i gumowym, wygodnym uchwytem, linia pisania EXTRA FINE 0.32 mm.",
                Price = 2.99m,
            },

            new Product
            {
            Id =2,
            Name = "Długopis żelowy",
            Description = "Smukła obudowa zapewnia komfortowe trzymanie, a gumowy uchwyt zapobiega ślizganiu się palców.",
            Price = 4.65m,
            },

            new Product
            {
                Id =3,
                Name = "Długopis zmywalny",
                Description = "Dzięki rewelacyjnym długopisom STARPAK możesz natychmiast poprawić swoje błędy i pomyłki.",
                Price = 7.49m,
            },

            new Product
            {
                Id =4,
                Name = "Pióro wieczne",
                Description = "Pióro wieczne eleganckie to dobry pomysł na prezent.",
                Price = 43.51m,
            },

            new Product
            {
                Id =5,
                Name = "Pióro kulkowe",
                Description = "Pióro Twist Pelikan kulkowe w pastelowych kolorach doskonale sprawdzi się jako prezent.",
                Price = 28.99m,
            }
        };

        public List<Product> GetAll()
        {
            return Products;
        }

        public Product GetById(int id)
        {
            return Products.SingleOrDefault(p => p.Id == id);
        }

        public void Create(Product model)
        {
            model.Id = GetNextId();
            Products.Add(model);
        }

        public int GetNextId()
        {
            if (!Products.Any())
                return 0;
            return (Products?.Max(m => m.Id) ?? 0) + 1;
        }

        public void Update(Product model)
        {
            var product = GetById(model.Id);
            product.Name = model.Name;
            product.Description = model.Description;
            product.Price = model.Price;
        }

        public void Delete(int id)
        {
            var product = GetById(id);
            Products.Remove(product);
        }
    }
}
