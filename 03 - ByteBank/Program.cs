using _03___ByteBank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03__ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //CRIANDO UM NOVO CLIENTE  
            //Cliente camila = new Cliente();
            //camila.nomeCompleto = "camila maculan gaieski";
            //camila.idade = 21;
            //camila.telefone = 41996136261;
            //camila.PrefGatoCachorro = "cachorro";

            //CRIANDO UMA NOVA CONTACORRENTE
            //ContaCorrente conta = new ContaCorrente();
            //conta.titular = camila;
            //conta.agencia = 384238;
            //conta.digito = 5;
            //conta.saldo = 1200;

            //CRIANDO UMA CONTA ATRAVÉS DO TITULAR DENTRO DA CONTA CORRENTE
            ContaCorrente conta = new ContaCorrente();
            conta.titular = new Cliente();
            conta.titular.nomeCompleto = "camila maculan gaieski";
            conta.titular.idade = 21;
            conta.titular.telefone = 41996136261;

            Console.WriteLine(conta.titular.nomeCompleto + conta.titular.telefone);










        }
        
    }
   
}
