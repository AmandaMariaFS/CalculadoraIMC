public class Pessoa
{
    public String Nome { get; set; }
    public double Altura { get; set; }
    public double Peso {  get; set; } 
    public double Imc { get => Peso / (Altura * Altura); }
    
    public Pessoa ()
    {
        Nome = " ";
        Altura = 0;
        Peso = 0;
    }

    public void PesoIdeal()
    {
        double pesoIdeal = 0.0;
        if (Imc > 25)
        {
            pesoIdeal = 24.9 * Altura * Altura;
            Console.WriteLine("Para estar no peso normal é necessário emagrecer {0} kg", Peso - pesoIdeal);
        }
        else if (Imc < 18.5)
        {
            pesoIdeal = 18.5 * Altura * Altura;
            Console.WriteLine("Para estar no peso normal é necessário engordar {0} kg", pesoIdeal - Peso);
        }
    }

    public String FaixaImc()
    {
        if (Imc > 40)
    {
        return "obesidade III";
    }
    else if (Imc > 35)
    {
        return "obesidade II";
    }
    else if (Imc > 30)
    {
        return "obesidade I";
    }
    else if (Imc > 25)
    {
        return "acima do peso";
    }
    else if (Imc > 18.5)
    {
        return "peso ideal";
    }
    else if (Imc > 17)
    {
        return "abaixo do peso";
    }
    else
    {
        return "muito abaixo do peso";
    }
    }
}