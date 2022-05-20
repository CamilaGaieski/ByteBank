using System;

namespace _04_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente camila = new ContaCorrente();
                
            camila.Saldo = (-53);
            Console.WriteLine(camila.Saldo);
        }
    }
}
