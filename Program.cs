using System.Collections;
namespace ZadachaOtChasa
{
    internal class Program
    {
        private static ArrayList products = new ArrayList();

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            products.Add("Chushki"); 
            products.Add(2.20); 
            products.Add(5);
            products.Add("Domati"); 
            products.Add(1.50); 
            products.Add(2);
            products.Add("Patlajani"); 
            products.Add(3.40); 
            products.Add(1);

            List<string> product = new List<string>();
            List<double> prices = new List<double>();
            List<int> quantity = new List<int>();

            for(int i = 0; i < products.Count; i++)
        {
                switch (products[i]) 
                {
                    case string: 
                        product.Add((string)products[i]);
                        break;
                    case double: 
                        prices.Add((double)products[i]);
                        break;
                    case int: 
                        quantity.Add((int)products[i]);
                        break;
                }
            }
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"{"Produkti:",-10} {"Kolichestvo:",13} {"Cena:",12} {"Suma:",11}");

            for (int i = 0; i < product.Count; i++)
            {
                double sum = prices[i] * quantity[i]; 
                Console.WriteLine($"{product[i],-10} {quantity[i],13} {prices[i],12:C2} {sum,11:C2}");
            }

            Console.ResetColor();
        }
    }
}