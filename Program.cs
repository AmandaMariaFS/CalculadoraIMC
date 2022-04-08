
Console.WriteLine("Entre com seu nome: ");
string nome = Console.ReadLine();

Console.WriteLine("Entre com sua altura em metros. Ex: 1,65");
float altura = Convert.ToSingle(Console.ReadLine());

Console.WriteLine("Entre com seu peso em Kg. Ex: 67,7");
float peso = Convert.ToSingle(Console.ReadLine());

double imc = peso / (altura * altura);

Console.WriteLine("{0}, sua altura é {1} e seu peso {2}", nome, altura, peso);
Console.WriteLine("Seu IMC é {0}", imc);

if (imc > 40)
{
    Console.WriteLine("Você está na faixa de Obesidade III");
}
else if (imc > 35)
{
    Console.WriteLine("Você está na faixa de Obesidade II");
}
else if (imc > 30)
{
    Console.WriteLine("Você está na faixa de Obesidade I");
}
else if (imc > 25)
{
    Console.WriteLine("Você está acima do peso");
}
else if (imc > 18.5)
{
    Console.WriteLine("Você está no peso normal");
}
else if (imc > 17)
{
    Console.WriteLine("Você está abaixo do peso");
}
else
{
    Console.WriteLine("Você está muito abaixo do peso");
}

double pesoIdeal = 0.0;
if (imc > 25)
{
    pesoIdeal = 24.9 * altura * altura;
    Console.WriteLine("Para estar no peso normal é necessário emagrecer {0} kg", peso - pesoIdeal);
}
else if (imc < 18.5)
{
    pesoIdeal = 18.5 * altura * altura;
    Console.WriteLine("Para estar no peso normal é necessário engordar {0} kg", pesoIdeal - peso);
}