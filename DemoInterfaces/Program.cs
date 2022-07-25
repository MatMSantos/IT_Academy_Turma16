Pessoa p1 = new Pessoa("John Doe", 20);
Pessoa p2 = new Pessoa("Mary Doe", 20);
Pessoa p3 = new Pessoa("John Doe", 20);
Pessoa p4 = p1;

// Diferenças entre igualdades

System.Console.WriteLine("Igualdade de referência:");
Console.WriteLine(p1 == p4); // Se desejar, é possível sobrescrever este operador
Console.WriteLine(p1 == p3);

System.Console.WriteLine("Igualdade de valor:");
Console.WriteLine(p1.Equals(p4));
Console.WriteLine(p1.Equals(p3));
Console.WriteLine(p1.Equals(p2));

Console.WriteLine(p1.GetHashCode());
Console.WriteLine(p3.GetHashCode()); // GetHashCode não implementada: Códigos de hash diferentes; Implementada: Códigos de hash iguais      

Pessoa outra = (Pessoa) p2.Clone();