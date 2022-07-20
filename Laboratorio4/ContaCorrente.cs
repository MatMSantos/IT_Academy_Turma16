public class ContaCorrente
{
    private decimal saldo; // Valor default é zero

    public decimal Saldo // Propriedades não tem parênteses
    {
        get { return saldo; }
        // get => saldo --> também funciona
    }
    // public decimal Saldo => saldo; // Mesma coisa que o getter de cima (propriedade de leitura)

    public DateTime DataCriacao { get; }

    public void Depositar(decimal valor)
    {
        saldo += valor;
    }

    public void Sacar(decimal valor)
    {
        saldo -= valor;
    }

    public ContaCorrente(decimal valor)
    {
        saldo = valor;
        DataCriacao = DateTime.Now; // Só pode ser inicializada no construtor
    }
}