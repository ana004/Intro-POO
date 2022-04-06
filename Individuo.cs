public class Individuo 
{
    public string Nome { get; set; }
    public double Altura { get; set; }
    public double Peso { get; set; }
    public Individuo(string Nome, double Altura, double Peso)
    {
        this.Nome = Nome;
        this.Altura = Altura;
        this.Peso = Peso;
    }

    public double Imc { get => Peso / (Altura*Altura); }


    /*
    public double PesoGanhar
    { 
        get 
        {
           Massa = Math.Round(18.50*(Altura*Altura), 2);
           PesoGanharPerder = Massa - Peso; 
        }
    }

    public double PesoPerder
    {
        get 
        {
            Massa = Math.Round(24.99*(Altura*Altura), 2);
            PesoGanharPerder = Peso - Massa;
        }
    }*/
}