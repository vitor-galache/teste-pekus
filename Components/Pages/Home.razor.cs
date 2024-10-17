using CalculadoraPekus.Data;
using CalculadoraPekus.Enums;
using CalculadoraPekus.Models;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace CalculadoraPekus.Components.Pages;

public partial class HomePage : ComponentBase
{
    public Calculo CalculoModel { get; set; } = new();

    [Inject] public NavigationManager NavigationManager { get; set; } = null!;
    [Inject] public AppDbContext DbContext { get; set; } = null!;
    [Inject] public ISnackbar Snackbar { get; set; } = null!;

    public async Task OnValidSubmitAsync()
    {
        switch (CalculoModel.TipoCalculo)
        {
            case ETipoCalculo.Soma:
                CalculoModel.Somar();
                break;

            case ETipoCalculo.Subtracao:
                CalculoModel.Subtrair();
                break;

            case ETipoCalculo.Multiplicacao:
                CalculoModel.Multiplicar();
                break;
            
            case ETipoCalculo.Divisao:
                if (CalculoModel.ValorA < CalculoModel.ValorB)
                {
                    Snackbar.Add("O valor A não pode ser menor que o B na operação de divisão", Severity.Error);
                    return;
                }
                CalculoModel.Dividir();
                break;
        }
        
        CalculoModel.DataCalculo = DateTime.Now;

        await DbContext.Calculos.AddAsync(CalculoModel);
        await DbContext.SaveChangesAsync();
        NavigationManager.NavigateTo("/historico");
        Snackbar.Add("Calculo registrado com sucesso!",Severity.Success);
    }
}