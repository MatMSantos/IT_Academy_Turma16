Fracao f1 = new Fracao(1,2);
Fracao f2 = new Fracao(3,4);

Console.WriteLine(f1.FracaoPorExtenso());
Console.WriteLine(f2.Numerador);

Fracao f3 = f1 * f2; // Se multiplicação não está implementada no objeto Fracao, isto aqui dá erro
Console.WriteLine(f3.FracaoPorExtenso()); // DICA: 'cw'+enter gera uma linha com System.Console.WriteLine()