using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente camila = new ContaCorrente(); 
            camila.telefone = 33451020;
            camila.saldo = 120;
            camila.nomeCompleto = "camila gaieski";
            camila.idade = 21;
            Console.WriteLine("Nome: " + camila.nomeCompleto + " telefone: " + camila.telefone + " idade: " + camila.idade + " saldo: " + camila.saldo);

            ContaCorrente camila02 = new ContaCorrente();
            camila02.telefone = 33451020;
            camila02.saldo = 120;
            camila02.nomeCompleto = "camila gaieski";
            camila02.idade = 21;
            Console.WriteLine("Nome: " + camila02.nomeCompleto + " telefone: " + camila02.telefone + " idade: " + camila02.idade + " saldo: " + camila02.saldo);

            Console.WriteLine("Igualdade de tipo de referência: " + (camila == camila02));

            int idade = 10;
            int idade02 = 10;

            Console.WriteLine("Igualdade de tipo de valor: " + (idade == idade02));
            Console.ReadLine();  
        }
    }
}
