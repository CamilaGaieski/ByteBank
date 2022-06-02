using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Sistemas
{
    public abstract class Autenticavel : Funcionario
    {
        public Autenticavel(double salario, string cpf)
            : base(salario, cpf)
        {
            //o funcionario estava reclamando que o salario não estava sendo instanciado, por isso puxamos esse
        }
        public string Senha { get; set; }   
        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }


    }
}
