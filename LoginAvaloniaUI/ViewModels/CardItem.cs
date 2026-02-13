using Avalonia.Media;

namespace LoginAvaloniaUI.ViewModels;

public sealed class CardItem
{
    public string Title { get; init; } = "";
    public string Description { get; init; } = "";
    public IBrush Color { get; init; } = Brushes.DodgerBlue;
    public IBrush HoverColor { get; init; } = Brushes.RoyalBlue;
}
