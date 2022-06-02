using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    
    public abstract class Funcionario//o funcionario é uma abstração do conceito de funcionario e agora não é mais possível instanciar (fazer new funcionario(determianr, valor) pois colocamos o abstract)
    {
        //static significa que é uma propriedade estática da classe 
        public static int TotalDeFuncionarios { get; private set; }


        private int _tipo; 
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; protected set; }//o protected é um modificador de acesso que define que eu posso modificar o salario e seus filhos apenas dentro da classe funcionario. 
        

        public Funcionario( double salario, string cpf)
        {
            TotalDeFuncionarios++;
            CPF = cpf;
            Salario = salario;
            //Console.WriteLine("Criando Funcionario");
        }

        public abstract void AumentarSalario();

        //colocando abstract eu digo que cada classe vai ter que instanciar o seu próprio aumentarSalario e GetBonoficação. 
        //Colocando o virtual eu estou dizendo que o getbonificação possibilita que uma classe filha e mais derivada, mude o comportamento desse método
        public abstract double GetBonificacao();
        

        //OBS: METODOS ABSTRATOS SÓ PODEM SER CRIADOS DE CLASSES ABSTRATAS
    }
}
