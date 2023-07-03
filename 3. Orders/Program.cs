using System.Security.Cryptography.X509Certificates;

namespace _3._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = " ";
            var products = new Dictionary<string, List<decimal>>();

            while ((input = Console.ReadLine()) != "buy")
            {
                var product = input
                    .Split()
                    .ToList();
                string productName = product[0];
                decimal productPrice = decimal.Parse(product[1]);
                decimal productQuantity = decimal.Parse(product[2]);

                if (!products.ContainsKey(productName))
                {
                    products.Add(productName, new List<decimal>());
                    products[productName].Add(productPrice);
                    products[productName].Add(productQuantity);
                }
                else
                {
                    products[productName][0] = productPrice;
                    products[productName][1] += productQuantity;
                    
                    
                }
            }
            foreach (var product in products)
            {
                Console.WriteLine($"{product.Key} -> {product.Value[0] * product.Value[1]:f2}");
            }
        }
    }
}