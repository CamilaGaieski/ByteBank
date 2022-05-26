using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05___ByteBank
{
    public class Cliente
    {
        private double _idade
        {
            get
            {
                return _idade;    
            }
            set
            {
                //colocar minha lógica de validação de CPF se for o caso. 
                _idade = value;   
            }
        }
        public string NomeCompleto { get; set; }
        public int Idade { get; set; }
        public double Telefone { get; set; }
        public string PrefGatoCachorro { get; set; }
    }
}
