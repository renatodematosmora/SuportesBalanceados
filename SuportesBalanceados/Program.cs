using System;

namespace SuportesBalanceados
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = "Renato{(de)((((({Matos)))))}{}{}";
            Console.WriteLine(Colchete.ValidaColchetes(texto));
        }
    }
}
