using System;

namespace Dictionaryy
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary <int, string> product = new MyDictionary<int, string>();

            product.Add(12, "urun1");
            product.Add(13, "urun2");
            product.Add(14, "urun3");

  


            Console.WriteLine(product.count);
            
          
        

            

        }
    }
}
