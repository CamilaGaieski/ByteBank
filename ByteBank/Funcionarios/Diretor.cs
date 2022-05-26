using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
// o diretor herdou o nome, cpf, e salario do Funcionario, por isso não precisa escrever novamente. 
    public class Diretor : Funcionario
    {
        public Diretor(string cpf) : base(5000, cpf)//todo diretor começa com salario de 5mil 
        {

        }
        public override void AumentarSalario() 
        {
            Salario *= 1.15;

        }

        // colocando esse override eu digo que esse get pode ser sobreescrito (eu quero sobrepor a implementação da classe base) 
        public override double GetBonificacao()
        {
            //ao colocar o base.getbonificação eu peguei o get dos funcionarios que é a classe base do get e coloquei aqui pra somar pq se colocasse só o + (salario * 0.10) ia dar erro System.StackOverflowException que significa que o programa ficou voltando na mesma e acabou com a memoria (o programa ate roda mas ele fecha logo em seguida)
            return Salario + base.GetBonificacao();
        }
    }
}
