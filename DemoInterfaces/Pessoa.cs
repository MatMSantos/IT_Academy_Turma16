public class Pessoa : IEquatable<Pessoa>, ICloneable
{
    private string nome;
    private int idade;
    public Pessoa(string n, int i)
    {
        nome = n;
        idade = i;
    }
    public string Nome
    {
        get { return nome; }
    }
    public int Idade
    {
        get { return idade; }
    }

    public object Clone() // Shallow copy: cópia de referência; Deep copy: cópia de valor
    {
        Pessoa outra = (Pessoa) MemberwiseClone(); // shallow copy
        outra.nome = new String(nome);
        return outra;
    }

    public bool Equals(Pessoa? outra) // Herdado de IEquatable
    {
        if (outra == null) return false;
        return (nome == outra.nome && idade == outra.idade);
    }
    public override bool Equals(object? obj) // Herdado de qualquer objeto (genérico)
    {
        Pessoa? outra = obj as Pessoa;
        return Equals(outra);
    }

    // Quase sempre quando temos que sobrescrever o Equals temos que sobrescrever o GetHashCode
    public override int GetHashCode()
    {
        return nome.GetHashCode() + idade.GetHashCode();
    }
}