using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Funcionario
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
        }

        public virtual void  AumentarSalario()
        {
            //Salario = Salario + (Salario * 0.1); --- Jeitos iguais de fazer a mesma coisa. 
            //Salario = Salario * 1.1;
            Salario *= 1.1;

        }

        //Colocando esse virtual eu estou dizendo que o getbonificação possibilita que uma classe filha e mais derivada, mude o comportamento desse método
        public virtual double GetBonificacao()
        {
           return Salario *0.10;
        }



    }
}
