public class ContaEmpresa : Conta 
{
    private double _anuidade;
    private double _limiteEmprestimo;
    private double _totalEmprestimo;

    // Get e Set
    public double getAnuidade()
    {
        return _anuidade;
    }
    public void setAnuidade(double anuidade)
    {
        this._anuidade = anuidade;
    }
    public double getLimiteEmprestimo()
    {
        return _limiteEmprestimo;
    }
    public void setLimiteEmprestimo(double limite)
    {
        this._limiteEmprestimo = limite;
    }
    public double getTotalEmprestimo()
    {
        return _totalEmprestimo;
    }

    //Métodos
    public override void Sacar(double valor)
    {
        //Terminar
        if (valor > 5000)
        {
            valor += 5.00;
            _saldo -= valor;
        } else base.Sacar(valor);
    }

    public void FazerEmprestimo(double valor)
    {
        if (valor <= _limiteEmprestimo - _totalEmprestimo)
        {
            //Implementar regra
            _saldo += valor;
            _totalEmprestimo += _saldo;
            //Console.WriteLine("* u *");
        }
        else throw new Exception("Inválido");
               
    }

}
