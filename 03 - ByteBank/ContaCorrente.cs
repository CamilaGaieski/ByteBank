using _03___ByteBank;


public class ContaCorrente

{
    //agora o titular não é uma string, ele é uma referência de um objeto cliente. 
    public Cliente titular;
    public double agencia;
    public int digito;    
    public double saldo = 100;

    public bool Sacar(double valor)
    {
        if (saldo < valor)
        {
            return false;
        }
        else
        {
            saldo -= valor;
            return true;
        }
    }
    // SACAR TRANSFERIR E ETC SÃO MÉTODOS
    public void Depositar(double valor)
    {
        saldo += valor;
    }

    public bool Transferir(double valor, ContaCorrente contaDestino)
    {
        if (saldo < valor)
        {
            return false;
        }
        else
        {
            saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }

}


