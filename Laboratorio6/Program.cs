List<Conta> contas = new List<Conta>();
contas.Add(new ContaCorrente("Mateus"));
contas.ForEach(c => Console.WriteLine(c.Id)); // Funciona por causa do polimorfismo