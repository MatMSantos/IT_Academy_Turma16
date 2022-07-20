// Queremos trabalhar diretamente na pilha, não com referências
// Temos uma struct readonly, ou seja, os membros da Fração são imutáveis

// Não posso usar herança!
public readonly struct Fracao
{
    private readonly int num;
    private readonly int den;

    public Fracao(int numerador, int denominador)
    {
        // Assumir denominador diferente de zero
        num = numerador;
        den = denominador;
    }

    // Leitura do Numerador e Denominador
    public int Numerador => num;
    public int Denominador => den;

    // Método com sintaxe curta
    // Poderia ter sobrescrito ToString
    public string FracaoPorExtenso() => $"{num}/{den}";

    // Sobrescrita de operadores
    // Operador de multiplicação de frações
    public static Fracao operator *(Fracao a, Fracao b) => new Fracao(a.num * b.num, a.den * b.den);
    /* OU:
    public static Fracao operator *(Fracao a, Fracao b)
    {
        return new Fracao(a.num * b.num, a.den * b.den);
    }
    */
}