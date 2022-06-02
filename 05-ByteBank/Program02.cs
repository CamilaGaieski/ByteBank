using System;
using ByteBank.Funcionarios;

namespace ByteBank
{
    internal class Program02
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao ByteBank");
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();
            //CTLR + . mostra possíveis correções. 
            Funcionario Vanessa = new Funcionario(500, "112.232.123 - 12");
            Vanessa.Nome = "Vanessa Camargo Fashion";
            Vanessa.CPF = "112.232.123-12";
           

            Funcionario adilson = new Funcionario(1500, "234.323.564-85");
            adilson.Nome = "adilsinho de xuxu beleza";
            adilson.CPF = "234.323.564-85";
     


            Diretor Carlos = new Diretor("122.123.233-45");
            Carlos.Nome = "Carlos Alberto de Nobrega";
            Carlos.CPF = "122.123.233-45";
    

            GerenciadorBonificacao funcionario = new GerenciadorBonificacao();
            
            //registra o funcionario para fazer parte do plano de bonificação da empresa  
            gerenciador.Registrar(Vanessa);
            gerenciador.Registrar(Carlos);
            gerenciador.Registrar(adilson);

            Console.WriteLine("Nome: " + Vanessa.Nome);
            Console.WriteLine("Bonificação: " +  Vanessa.GetBonificacao());
            Console.WriteLine("Nome: " + Carlos.Nome);
            Console.WriteLine("Bonificação: " + Carlos.GetBonificacao());
            Console.WriteLine("Nome: " + adilson.Nome);
            Console.WriteLine("Bonificação: " + adilson.GetBonificacao());

            Console.WriteLine("total bonificãções: " + gerenciador.GetTotalBonificacao());

            Console.WriteLine("total de funcionarios: " + Funcionario.TotalDeFuncionarios);

            Carlos.AumentarSalario();
            Console.WriteLine("salario novo do Carlos: " + Carlos.Salario);

        }
    }
}
