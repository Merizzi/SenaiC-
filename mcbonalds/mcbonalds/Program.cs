using System;

namespace mcbonalds
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente("Pablo","55 11 2020-2020", "pbo@merissi.com");
            Console.WriteLine("Nome: " + cliente1.Nome);
            Console.WriteLine("Telefone: " + cliente1.Telefone);
            Console.WriteLine("Email: " + cliente1.Email);
        }
    }
}
