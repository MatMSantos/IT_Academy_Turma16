public class ContaCorrente
{
    private Correntista correntista;
    private decimal saldo; // Valor default é zero

    public decimal Saldo // Propriedades não tem parênteses
    {
        get { return saldo; }
        // get => saldo --> também funciona
    }
    // public decimal Saldo => saldo; // Mesma coisa que o getter de cima (propriedade de leitura)

    public DateTime DataCriacao { get; }
    
    public Correntista Correntista => correntista; // retorna objeto correntista

    public void Depositar(decimal valor)
    {
        saldo += valor;
    }

    public void Sacar(decimal valor)
    {
        saldo -= valor;
    }

    public ContaCorrente(decimal valor, Correntista umCorrentista)
    {
        saldo = valor;
        DataCriacao = DateTime.Now; // Só pode ser inicializada no construtor
        correntista = umCorrentista;
    }

    /* Copia de codigo - RUIM
    public ContaCorrente(string nomeCorrentista, string cpfCorrentista)
    {
        saldo = 0;
        DataCriacao = DateTime.Now;
        correntista = new Correntista{Nome=nomeCorrentista,Cpf=cpfCorrentista};
    }
    */
    public ContaCorrente(string nomeCorrentista, string cpfCorrentista)
    : this(0,new Correntista{Nome=nomeCorrentista,Cpf=cpfCorrentista})
    { // Construtor sem reescrita de código
    }
}