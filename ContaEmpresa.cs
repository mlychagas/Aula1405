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
    // método sobrescrito
    public override void Sacar(double valor)
    {
        //Terminar
        if (valor > 5000 && valor <= _saldo - 5)
        {
            _saldo -= (valor + 5) ;

        } else if(valor < 5000) base.Sacar(valor);
        else throw new Exception("Inválido");
    }

    public void FazerEmprestimo(double valor)
    {
        if (valor <= _limiteEmprestimo - _totalEmprestimo)
        {
            _totalEmprestimo += valor;
            _saldo += valor;
        }
        else throw new Exception("Inválido");
               
    }

}
