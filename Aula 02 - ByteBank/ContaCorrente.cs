


public class ContaCorrente
{
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


