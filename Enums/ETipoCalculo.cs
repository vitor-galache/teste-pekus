using System.ComponentModel;

namespace CalculadoraPekus.Enums;

public enum ETipoCalculo
{
    [Description("Adição")]
    Soma = 1,
    [Description("Subtração")]
    Subtracao = 2,
    [Description("Multiplicação")]
    Multiplicacao = 3,
    [Description("Divisão")]
    Divisao = 4
}