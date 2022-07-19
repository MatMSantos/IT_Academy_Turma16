// See https://aka.ms/new-console-template for more information
// Isto não é possível:
//int x = null;
// Isto é possível:
int? y = null;
Console.WriteLine(y);
// Ou:
// string s = null;
string? t = null;
Console.WriteLine(t);

int? a = 28;
//int b = a; Erro: deve haver conversão explícita
int b = a ?? 0; // Se a for null, atribua 0 a b
Console.WriteLine(b);
int? c = null;
int d = c ?? 0;
Console.WriteLine(d);

int? e = a + c;
Console.WriteLine(e); // e tem o valor null

string st = null!; //null forgiving - eu sei o que estou fazendo com null

//DateTime dt = DateTime.Now;
//Console.WriteLine(dt.Day);
DateTime? dt = null;
Console.WriteLine(dt?.Day); // Se variável dt for diferente de null, pegue o Day. Se ela for nula, vai retornar null

// null forgiving - ! / null coalescing - ? / null conditional - ??
// Com testes:
if (dt != null) {
    Console.WriteLine(dt?.Day);
}

if (dt.HasValue) {
    Console.WriteLine(dt.Value.Day);
}