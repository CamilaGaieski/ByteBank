using _04___ByteBank;


public class ContaCorrente

{
    //agora o titular não é uma string, ele é uma referência de um objeto cliente. 
    private Cliente _titular;
    public double agencia;
    public int digito;    
    private double _saldo = 100;
    public Cliente Titular
    {
        get
        {
            return _titular;
        }
        set
        {
            _titular = value;
        }
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


