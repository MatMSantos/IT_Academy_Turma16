public abstract class Conta
{
    private decimal saldo;
    private string titular;
    public decimal Saldo
    {
        get { return saldo; }
    }
    public string Titular
    {
        get { return titular; }
    }
    public abstract string Id // Não pode chamar porque não foi implementada
    {
        get;
    }
    // Contrato: essa propriedade não está implementada mas tem nas subclasses (sobrescrito)
    // Sem abstract implementa Id, com abstract não implementa Id
    
    public virtual void Depositar(decimal valor)
    {
        saldo += valor;
    }
    public virtual void Sacar(decimal valor)
    {
        saldo -= valor;
    }
    public Conta(string t)
    {
        titular = t;
    }
}