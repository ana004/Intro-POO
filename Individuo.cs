public class Individuo 
{
    public string Nome { get; set; }
    public double Altura { get; set; }
    public double Peso { get; set; }
    public double Massa { get; set; }
    
    public Individuo(string Nome, double Altura, double Peso)
    {
        this.Nome = Nome;
        this.Altura = Altura;
        this.Peso = Peso;
    }

    public double Imc { get => Peso / (Altura*Altura); }

    public string FaixaImc { 
        get
            {
            if (Imc < 17)
                return "Muito abaixo do peso";
            else if (Imc >= 17 && Imc <= 18.49)
                return "Abaixo do peso";
            else if (Imc >= 18.50 && Imc <= 24.99)
                return "Peso normal";
            else if (Imc >= 25 && Imc <= 29.99)
                return "Acima do peso";
            else if (Imc >= 30 && Imc <= 34.99)
                return "Obesidade I";
            else if (Imc >= 35 && Imc <= 39.99)
                return "Obesidade II (severa)";


                return "Obesidade III (mórbida)";
            } 
    }


    public double MassaComecoFaixa { get => Massa = 18.50*Altura*Altura; }
    
    public double PesoGanhar { get => MassaComecoFaixa - Peso; }
    
    public double MassaFinalFaixa { get => Massa = 24.99*Altura*Altura; }
    
    public double PesoPerder { get => Peso - MassaFinalFaixa; }

    public string PesoGanharPerder 
    { 
        get{
                if (Imc < 18.50)
                return "Massa necessária para o peso normal (IMC 18,50): " + MassaComecoFaixa + "\n" + "Massa necessária a ganhar para chegar ao peso normal (IMC 18,50): " + PesoGanhar;

                if (Imc > 24.99) 
                return "Massa necessária para o peso normal (IMC 24.99): " + MassaFinalFaixa + "\n" + "Massa necessária a perder para chegar ao peso normal (IMC 24.99): " + PesoPerder;

                return " ";
            } 
    }
   
}