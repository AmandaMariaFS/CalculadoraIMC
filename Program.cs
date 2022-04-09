
Pessoa p1 = new Pessoa();

Console.WriteLine("Entre com seu nome: ");
p1.Nome = Console.ReadLine();

Console.WriteLine("Entre com sua altura em metros. Ex: 1,65");
p1.Altura = Convert.ToSingle(Console.ReadLine());

Console.WriteLine("Entre com seu peso em Kg. Ex: 67,7");
p1.Peso = Convert.ToSingle(Console.ReadLine());



Console.WriteLine("{0}, sua altura é {1} e seu peso {2}", p1.Nome, p1.Altura , p1.Peso );
Console.WriteLine("Seu IMC é {0}", p1.Imc);
Console.WriteLine("Você está na faixa {0}", p1.FaixaImc());
p1.PesoIdeal();

