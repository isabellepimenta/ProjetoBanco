Conta c1 = new Conta(1);
Conta c2 = new Conta(2);

Console.WriteLine("O valor é: {0} " + c1.Codigo);

Console.WriteLine("-------------------------------");

c1.Depositar(1000.00);
c1.Sacar(200.00);
Console.WriteLine("Valor depois do Sacar e do Depositar: {0}" + c1.Saldo);

c2.Depositar(200.00);
c2.Sacar(150.00);
Console.WriteLine("Valor depois do Sacar e do Depositar: {0}" + c2.Saldo);

Console.WriteLine("-------------------------------");

c1.Transferir(100.00, c2);
Console.WriteLine("Saldo depois de Transferir {0}" + c1.Saldo);
Console.WriteLine("Saldo depois de Transferir {0}" + c2.Saldo);