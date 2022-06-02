using System;

namespace _05__ByteBank
{
    internal class Program01
    {
        static void Main(string[] args)
        {

            {

                ContaCorrente camila = new ContaCorrente(767, 90989);
                camila.Saldo = (-53);
                

                ContaCorrente vivi = new ContaCorrente(767, 90989);
                vivi.Saldo = (-53);


                Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

                


                Console.ReadLine();


            }
        }
    }
}

