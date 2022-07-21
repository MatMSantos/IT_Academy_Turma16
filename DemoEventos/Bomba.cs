public class Bomba
{
    private int tics;
    public int TempoLimite {get; init;}
    public bool Explodiu {get; private set;} // C# permite modificar a restrição de acesso para leitura/escrita
    public event EventHandler? FezBum; // EventHandler Delegate (Tratador de eventos)

    public Bomba(int limite)
    {
        TempoLimite = limite;
    }

    public void Tic()
    {
        tics++;
        if (tics > TempoLimite && !Explodiu)
        {
            FazerBum();
        }
    }

    private void FazerBum()
    {
        Explodiu = true;
        if(FezBum != null)
        {
            FezBum(this, EventArgs.Empty);
        }
    }
}