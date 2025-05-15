public class Conta 
{
    private int _nConta;
    private string _agencia;
    private string _titular;
    protected double _saldo;
    
    public Conta()
    {
        _saldo = 0;
    }
    // Get e Set
    public int getnConta()
    {
        return _nConta;
    }
    public void setnConta(int nConta)
    {
        _nConta = nConta;
    }

    public string getAgencia()
    {
        return _agencia;
    }
    public void setAgencia(string agencia)
    {
        _agencia = agencia;
    }
    public string getTitular()
    {
        return _titular;
    }
    public void setTitular(string titular)
    {
        _titular = titular;
    }
    public double getSaldo()
    {
        return _saldo;
    }

    
    // Métodos
    public virtual void Sacar(double valor)
    {
        if (_saldo < valor)
        {
            throw new Exception("Saldo insuficiente");
        }
        else
        {
            _saldo -= valor;
            Console.WriteLine("Saque realizado!");
        }

    }

    public virtual void Depositar(double valor)
    {
        if (valor > 0)
        {
            _saldo += valor;
            Console.WriteLine("Valor depositado!");
        }
        else
        {
            throw new Exception("Valor inválido");
        }
    }

}
