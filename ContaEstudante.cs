using System.ComponentModel.Design;

public class ContaEstudante : Conta
{
    private double _limiteChequeEsp;
    private string _cpf;
    private string _nomeInstituicao;

    // get e set
    public double getLimite()
    {
        return _limiteChequeEsp;
    }
    public void setLimite(double limite)
    {
        _limiteChequeEsp = limite;
    }
    public string getCpf()
    {
        return _cpf;
    }
    public void setCpf(string cpf)
    {
        _cpf = cpf;
    }
    public string getNomeInstituicao()
    {
        return _nomeInstituicao;
    }
    public void setNomeintituicao(string nomeInstrituiao)
    {
        _nomeInstituicao = nomeInstrituiao;
    }

    // Métodos
    public override void Sacar(double valor)
    {
        if (_saldo <= 0)
        {
            if (valor <= _limiteChequeEsp)
            {
                _saldo -= valor;
                //Console.WriteLine("-U-");
            }
            else throw new Exception("Inválido");
        } else base.Sacar(valor);
        //implementar regra de saque até atingir o valor de cheque especial
        
    }
    
}