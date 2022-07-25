public class CirculoColorido : Circulo
{
    private string minhaCor; //Procurar na API do .net como colocar valores hex para cor
    public string Cor
    {
        get { return minhaCor; }
        set { minhaCor = value; }
    }
    public CirculoColorido()
    {
        minhaCor = "preto";
    }
    public CirculoColorido(double x, double y, double r, string c)
    : base(x,y,r)
    {
        minhaCor = c; 
    }
    public override string ToString()
    {
        return base.ToString() + $" cor={Cor}"; // Não precisa fazer diferente, porque a superclasse já faz um override de ToString
    }
    public new string ToStringHashCode() // Sem override. Para ocultar o método herdado, utilize 'new' (Muito cuidado!)
    {
        return "uma coisa qualquer"; // Não será impresso para uma coleção de Circulos
    }
}