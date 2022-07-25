Circulo circ1 = new Circulo();
Console.WriteLine(circ1);

Circulo circ2 = new Circulo(2.4, 5, 3);
Console.WriteLine(circ2);

CirculoColorido circ3 = new CirculoColorido();
System.Console.WriteLine(circ3);
CirculoColorido circ4 = new CirculoColorido(1.5, 3.1, 1, "vermelho");
System.Console.WriteLine(circ4); // Pacote do nugget: console com saídas coloridas (pesquisar)

LinkedList<Circulo> circulos = new LinkedList<Circulo>();
circulos.AddLast(circ1);
circulos.AddLast(circ2);
circulos.AddLast(circ3);
circulos.AddLast(circ4);
Console.WriteLine("Foreach polimórfico:");
foreach (var item in circulos)
{
    Console.WriteLine(item);
}
Console.WriteLine("Foreach não-polimórfico:");
foreach (var item in circulos)
{
    Console.WriteLine(item.ToStringHashCode());
}
Console.WriteLine($"Método de CirculoColorido diretamente: {circ4.ToStringHashCode()}"); // Tem que imprimir "uma coisa qualquer"
Console.WriteLine($"Método de Circulo fazendo casting: {((Circulo) circ4).ToStringHashCode()}"); // Tem que imprimir o código Hash (não é possível fazer circ4.base)

Console.WriteLine(circ4 is Circulo);
Console.WriteLine(circ4 is CirculoColorido);
CirculoColorido? circ1convertido = circ1 as CirculoColorido; // vai gerar null