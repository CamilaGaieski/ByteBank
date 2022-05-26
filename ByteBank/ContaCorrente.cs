using _05___ByteBank;


public class ContaCorrente

{
    //agora o titular não é uma string, ele é uma referência de um objeto cliente. 
    private Cliente _titular;
    public double Agencia { get; set; }
    public int Digito { get; set; }
    private double _saldo = 100;
    public Cliente Titular { get; set; }

    public static int TotalDeContasCriadas { get; private set; }

    //public static int ObterTotalDeContasCriadas()
    //{
    //    return TotalDeContasCriadas;
    //}

    public ContaCorrente(int digito, double agencia)
    {
        Digito = digito;
        Agencia = agencia;
        TotalDeContasCriadas++;
    }
    public double Saldo
    {
        get
        {
            return _saldo;
        }
        set
        {
            if (value < 0)
            {
                return;
            }
            else
            {
                _saldo = value;
            }
        }
    }

    public bool Sacar(double valor)
    {
        if (_saldo < valor)
        {
            return false;
        }
        else
        {
            _saldo -= valor;
            return true;
        }
    }
    // SACAR TRANSFERIR E ETC SÃO MÉTODOS
    public void Depositar(double valor)
    {
        _saldo += valor;
    }

    public bool Transferir(double valor, ContaCorrente contaDestino)
    {
        if (_saldo < valor)
        {
            return false;
        }
        else
        {
            _saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }

}


