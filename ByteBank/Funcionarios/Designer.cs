using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Designer : Funcionario //se uma classe não é abstracted automaticamente ela é uma classe concreta. (classes concretas podem ser instanciadas)  
    {
        public Designer(string cpf) : base(3000, cpf)
        {

        }
        public override void AumentarSalario()
        {
            Salario *= 1.11;

        }
        public override double GetBonificacao()
        {

            return Salario * 0.17;
        }
    }
}
