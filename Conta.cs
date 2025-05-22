public class Conta 
{
    private string _nConta;
    private string _agencia;
    private string _titular;
    protected double _saldo;
    
    public Conta()
    {
        _saldo = 0;
    }
    // Get e Set
    public string getnConta()
    {
        return _nConta; // o get sempre em um retorno
    }
    public void setnConta(string nConta)
    {
        _nConta = nConta; // sempre tem um parâmetro
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
        if (_saldo >= valor && valor > 0)
        {
            _saldo -= valor; 
        }
        else
        {
            throw new Exception("Saldo insuficiente");
        }

    }

    public virtual void Depositar(double valor)
    {
        if (valor <= 0)
        {
            throw new Exception("Valor inválido");
        }
        _saldo += valor;
        
        
    }

}
