static void TratadorDaExplosao(object? sender, EventArgs e)
{
    Console.WriteLine("A bomba explodiu!");
}

Bomba b = new Bomba(3);
b.FezBum += TratadorDaExplosao; // Adiciona um método, associa um método ao disparo do evento
b.Tic();
System.Console.WriteLine("tic");
b.Tic();
System.Console.WriteLine("tic");
b.Tic();
System.Console.WriteLine("tic");
b.Tic(); // Vai explodir aqui
System.Console.WriteLine("tic");