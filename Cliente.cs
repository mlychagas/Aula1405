public class Cliente
{
    public int _id;
    public string _nome;
    public string _email;

    public virtual void Salvar()
    {
        Console.WriteLine("Salvando Classe Base");
    }
}
