using System;
using System.Collections.Generic;
using System.Linq;

namespace Action
{
    class Program
    {


            
            
            
        public static void Main(string[] args)
        {
            //ActionExample();
            //FuncExample();
            PredicateExample();
        }


        private static void PredicateExample()
        {
            var products = new List<Product>();
            products.Add(new Product { Name = "Mochila", Value = 100 });
            products.Add(new Product { Name = "Notebook", Value = 3700 });
            products.Add(new Product { Name = "Teclado", Value = 200 });
            products.Add(new Product { Name = "Mouse", Value = 100 });
            products.Add(new Product { Name = "Cadeira", Value = 300 });

            Predicate<Product> cheapProductsPredicate = p => p.Value < 500;

            var cheapProducts = products.FindAll(cheapProductsPredicate);

            foreach (var item in cheapProducts)
            {
                Console.WriteLine($"Name: {item.Name}, Value: {item.Value}");
            }
        }

        private static void FuncExample()
        {
            var products = new List<Product>();
            products.Add(new Product { Name = "Mochila", Value = 100 });
            products.Add(new Product { Name = "Notebook", Value = 3700 });
            products.Add(new Product { Name = "Teclado", Value = 200 });
            products.Add(new Product { Name = "Mouse", Value = 100 });
            products.Add(new Product { Name = "Cadeira", Value = 300 });

            var valueList = products.Select(p => p.Value);

            foreach (var item in valueList)
            {
                Console.WriteLine(item);
            }
        }





        private static void ActionExample()
        {
            var products = new List<Product>();
            products.Add(new Product { Name = "Mochila", Value = 100 });
            products.Add(new Product { Name = "Notebook", Value = 3700 });
            products.Add(new Product { Name = "Teclado", Value = 200 });
            products.Add(new Product { Name = "Mouse", Value = 100 });
            products.Add(new Product { Name = "Cadeira", Value = 300 });

            //Criação de um variável do tipo Action<Product> e atribuindo a ela 
            //um método que tem um argumento e void
            Action<Product> actionProduct = SetSalePrice;
            products.ForEach(actionProduct);

            //Aqui eu criei a função inline, não precisando utlizar o método SetSalePrice.
            Action<Product> actionProduct2 = p => { p.Value -= p.Value * 0.2; };
            products.ForEach(actionProduct2);

            foreach (var item in products)
            {
                Console.WriteLine($"Produto: {item.Name}, valor: {item.Value}");
            }
        }


        private static void SetSalePrice(Product product)
        {
            product.Value -= product.Value * 0.2;
        }
    }
}
