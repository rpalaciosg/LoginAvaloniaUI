using System.Collections.ObjectModel;
using Avalonia.Media;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LoginAvaloniaUI.Services;

namespace LoginAvaloniaUI.ViewModels;

public sealed partial class MainWindowViewModel : ObservableObject
{
    private readonly IAppLifetimeService _appLifetimeService;

    public MainWindowViewModel(IAppLifetimeService appLifetimeService)
    {
        _appLifetimeService = appLifetimeService;
    }

    [RelayCommand]
    private void Exit()
    { 
        _appLifetimeService.Shutdown();
    }

    public ObservableCollection<CardItem> Cards { get; } = new()
    {
        new CardItem
        {
            Title = "Ventas",
            Description = "Resumen diario de ventas y tickets.",
            Color = new SolidColorBrush(Color.Parse("#1E88E5")),
            HoverColor = new SolidColorBrush(Color.Parse("#1565C0")),
        },
        new CardItem
        {
            Title = "Inventario",
            Description = "Productos con bajo stock y alertas.",
            Color = new SolidColorBrush(Color.Parse("#43A047")),
            HoverColor = new SolidColorBrush(Color.Parse("#2E7D32")),
        },
        new CardItem
        {
            Title = "Clientes",
            Description = "Clientes frecuentes y promociones.",
            Color = new SolidColorBrush(Color.Parse("#F4511E")),
            HoverColor = new SolidColorBrush(Color.Parse("#E64A19")),
        },
    };
}
