public class ClientePf : Cliente 
{
    public string _datanascimento;
    public string _cpf;

    public override void Salvar()
    {
        Console.WriteLine("Salvando o cliente pf");

    }

}
