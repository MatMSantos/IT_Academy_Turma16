List<string> listaStrings = new List<string>();
listaStrings.Add("Um");
listaStrings.Add("Hello");
listaStrings.Add("World");
Console.WriteLine(listaStrings[0]);
// Console.WriteLine(listaStrings[3]); // Index out of range
listaStrings[0] = "Alterado"; // Indexador é uma propriedade de leitura e escrita
// System.Console.WriteLine(listaStrings); // Nome da classe, mesmo que aconteceu no Laboratorio 2 com array
System.Console.WriteLine(listaStrings[0]);
System.Console.WriteLine(listaStrings.Count); // Número de elementos na lista

/*
foreach (var item in listaStrings)
{
    System.Console.WriteLine(item);
} Faz a mesma coisa do que está escrito em uma linha abaixo
*/

// Delegates são referências para métodos
// "Para cada elemento da lista, use este método"
listaStrings.ForEach(Console.WriteLine);
// Arrow function (lambda)
listaStrings.ForEach(item => Console.WriteLine(item.Length));
        // Multiparadigma: mistura Imperativa com OO com Funcional

// Predicate: retorna variável booleana
var elemento = listaStrings.Find(item => item[0]=='H');
System.Console.WriteLine(elemento);