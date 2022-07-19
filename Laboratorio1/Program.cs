// See https://aka.ms/new-console-template for more information

// É necessário e obrigatório atribuir valor a uma variável antes de acessá-la
byte b;
b = byte.MaxValue; //255

// Concatenação de Strings
Console.WriteLine("Valor máximo de byte: " + b);

// Interpolação de strings
Console.WriteLine($"Valor máximo de byte: {b}");

string strPrimeira = "Alô ";
string strSegunda = "Mundo";
string strTerceira = strPrimeira + strSegunda;

Console.WriteLine(strTerceira);

int cchTamanho = strTerceira.Length;
string strQuarta = "Tamanho = " + cchTamanho.ToString(); // Explicitamente chamando ToString()
Console.WriteLine(strQuarta);

DateTime dt = new DateTime(2022,7,19); // DateTime possui sobrecarga de operadores, então podemos somar duas datas diretamente, etc.
Console.WriteLine(dt.ToShortDateString());

// Horário atual
DateTime agora = DateTime.Now;
Console.WriteLine(agora);

int i = 10;
float f = 0;
f = i;
Console.WriteLine(f);
f = 0.5f; // Números com ponto flutuante SEMPRE são double, precisa especificar que é float
i = (int) f;

Console.WriteLine(i);