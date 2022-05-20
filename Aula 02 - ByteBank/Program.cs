using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando um novo cliente 
            ContaCorrente Camila = new ContaCorrente();
            //o bool foi colocado aqui pra permitir sabermos se deu certo o saque ou não.
            bool resultadoSaque = Camila.Sacar(200);

            Console.WriteLine("A operação de saque foi bem sucedida? ");
            // se deu boa aparece tal coisa se não diz pro usuário que deu ruim. 
            if (resultadoSaque == true)
            {
                Console.WriteLine("sim");
            }
            else
            {
                Console.WriteLine("Não pois o valor solicitado foi maior que o limite");
            }
            //mostra o saldo da conta 
            Console.WriteLine("Seu saldo é: " + Camila.saldo);

            // depositar na conta e mostrar o resultado
            Camila.Depositar(200);
            Console.WriteLine("Seu saldo após depósito é: " + Camila.saldo);

            //criar uma conta pro exemplo transferir
            ContaCorrente Vinicius = new ContaCorrente();
            //transferir
            bool resultadoTransferencia = Camila.Transferir(100, Vinicius);
            Console.WriteLine("Saldo de Camila após transferência: " + Camila.saldo);
            Console.WriteLine("Saldo de Vinicius após transferência: " + Vinicius.saldo);


            if (resultadoTransferencia == true)
            {
                Console.WriteLine("deu certo a transferência");
            }
            else
            {
                Console.WriteLine("Não deu boa");
            }

            //Finaliza a exiibição. 
            Console.ReadLine();
        }
    }
}
