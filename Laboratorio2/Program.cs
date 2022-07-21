// Arrays
// São por referência
// Não podem ter tamanho alterado
// Inicializar por new ou valores diretamente
// Posições indexáveis (propriedade indexadora):
//      igual a C, não pode ser indexado por números negativos (como em Python)

// Três formas de inicializar
int [] array = {10, 20, 30, 40, 50}; //Compilador vai decidir que o tamanho é 5
var arrayVar = new int[5] {10, 20, 30, 40, 50};
int[] arrayInst = new int[5] {10, 20, 30, 40, 50};

// For clássico, estilo C
for (int i=0; i<array.Length; i++)
{
    Console.WriteLine($"Índice = {i} Valor = {array[i]}");
}

// Mesma coisa, laço de repetição explícito
var j = 0;
while (j<array.Length)
{
    Console.WriteLine($"Índice = {j} Valor = {array[j]}");
    j++;
}

// Coleção precisa ser iterável
// (neste caso a coleção é o array)
foreach (var item in array)
{
    Console.WriteLine(item);
}

// Cada posição tem null, valor default para um tipo referência
string[] palavras = new string[3];
// System.Console.WriteLine(palavras[0]); // Imprime em branco
palavras[0] = "Um";
palavras[1] = "Dois";
palavras[2] = "Três";
System.Console.WriteLine(palavras); // Imprime o resultado de ToString(): "System.String[]" - o nome da classe (array de strings)
System.Console.WriteLine(palavras.Length); // Imprime 3
System.Console.WriteLine(palavras.Rank); // Número de dimensões: 1 (array unidimensional)

// Arrays podem ser unidimensionais, multidimensionais e jagged
//      int[,] codigos = new int[2,2];
//      codigos[0,0] = 11
// Arrays multidimensionais não são arrays de arrays!!
System.Console.WriteLine("Exemplo da matriz:");
int[,] matriz = new int[2,2]; // Matriz 2x2
matriz[0,0] = 1;
matriz[1,1] = 1;

// Não indexa uma linha inteira, mas sim toda a coleção de valores, independente do número de dimensões
// Isto é diferente de python, por exemplo
foreach(var linha in matriz)
{
    // Imprime item por item de uma linha, depois a outra, depois a outra...
    System.Console.WriteLine(linha);
}

System.Console.WriteLine($"Número de dimensões: {matriz.Rank}");
System.Console.WriteLine($"Número de elementos: {matriz.Length}");

// Jagged:
// É array de arrays!!
System.Console.WriteLine("Exemplo de array jagged:");
int[][] jagged = new int[2][];
jagged[0] = new int[3] {1, 2, 3}; // Precisa deixar explícito "new int"
jagged[1] = new int[2];

System.Console.WriteLine($"Número de dimensões array jagged: {jagged.Rank}");
System.Console.WriteLine($"Tamanho do array jagged: {jagged.Length}");
System.Console.WriteLine($"Número de dimensões linha 0: {jagged[0].Rank}");
System.Console.WriteLine($"Tamanho do array na posição 0: {jagged[0].Length}");
System.Console.WriteLine($"Número de dimensões linha 1: {jagged[1].Rank}");
System.Console.WriteLine($"Tamanho do array na posição 0: {jagged[1].Length}");

// var subarray é um array de inteiros
foreach (var subarray in jagged)
{
    foreach (var item in subarray)
    {
        System.Console.WriteLine(item);
    }
}