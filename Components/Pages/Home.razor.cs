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
        if (CalculoModel.ValorA == 0 || CalculoModel.ValorB == 0)
        {
            Snackbar.Add("Os dois valores devem ser diferentes de 0",Severity.Warning);
            return;
        }
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