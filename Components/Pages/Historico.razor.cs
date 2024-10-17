using CalculadoraPekus.Data;
using CalculadoraPekus.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;

namespace CalculadoraPekus.Components.Pages;

public partial class HistoricoPage : ComponentBase
{
    public List<Calculo> _calculos = new();

    [Inject] private AppDbContext DbContext { get; set; } = null!;

    protected override async Task OnInitializedAsync()
    {
        _calculos = await DbContext.Calculos.ToListAsync();
    }
}