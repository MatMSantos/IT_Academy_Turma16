public class Figura 
{

    // readonly em string não é a mesma coisa que readonly struct, onde todos os campos são readonly
    private readonly string nomeDaClasse; // Não sou obrigado a inicializar, mas assim que inicializar não pode ser mudado

    public string NomeDaClasse => nomeDaClasse;

    public Figura()
    {
        nomeDaClasse = this.GetType().AssemblyQualifiedName ?? String.Empty; // Se não tem nome, string vazia (null coalescing)
    }

    /*
    public void AlteraNome(string nome)
    {
        //erro de compilação
        nomeDaClasse = nome;
    } <-- Não funciona, nomeDaClasse é readonly e já foi definida
    */
}