using System.ComponentModel.DataAnnotations;
using CalculadoraPekus.Enums;

namespace CalculadoraPekus.Models;

public class Calculo
{
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Selecione o tipo de operação")]
    public ETipoCalculo TipoCalculo { get; set; } = ETipoCalculo.Soma;
    
    [Required(ErrorMessage = "Insira o primeiro valor")]
    public double ValorA { get; set; }
    
    [Required(ErrorMessage = "Insira o segundo o valor")]
    public double ValorB { get; set; }

    public double Resultado { get; set; }

    public DateTime DataCalculo { get; set; }

    public void Somar()
    {
        Resultado = ValorA + ValorB;
    }

    public void Subtrair()
    {
        Resultado = ValorA - ValorB;
    }

    public void Multiplicar()
    {
        Resultado = ValorA * ValorB;
    }

    public void Dividir()
    {
        Resultado = ValorA / ValorB;
    }
}