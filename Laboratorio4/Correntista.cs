public class Correntista
{
    public string Nome {get; set;} = String.Empty; // Leitura e escrita
    public string Cpf {get;init;} = null!; // Leitura e inicialização (null forgiving)
    private int anoNascimento;
    public int AnoNascimento
    {
        get => anoNascimento;
        set => anoNascimento = value;
    }
}