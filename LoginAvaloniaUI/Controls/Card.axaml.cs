using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;

namespace LoginAvaloniaUI.Controls;

public partial class Card : UserControl
{
    public static readonly StyledProperty<string> TitleProperty =
        AvaloniaProperty.Register<Card, string>(nameof(Title), "");

    public static readonly StyledProperty<string> DescriptionProperty =
        AvaloniaProperty.Register<Card, string>(nameof(Description), "");

    public static readonly StyledProperty<string> ButtonTextProperty =
        AvaloniaProperty.Register<Card, string>(nameof(ButtonText), "Ver detalles");

    public static readonly StyledProperty<IBrush> ButtonColorProperty =
        AvaloniaProperty.Register<Card, IBrush>(nameof(ButtonColor), Brushes.DodgerBlue);

    public static readonly StyledProperty<IBrush> ButtonHoverColorProperty =
        AvaloniaProperty.Register<Card, IBrush>(nameof(ButtonHoverColor), Brushes.DodgerBlue);

    public string Title
    {
        get => GetValue(TitleProperty);
        set => SetValue(TitleProperty, value);
    }

    public string Description
    {
        get => GetValue(DescriptionProperty);
        set => SetValue(DescriptionProperty, value);
    }

    public string ButtonText
    {
        get => GetValue(ButtonTextProperty);
        set => SetValue(ButtonTextProperty, value);
    }

    public IBrush ButtonColor
    {
        get => GetValue(ButtonColorProperty);
        set => SetValue(ButtonColorProperty, value);
    }

    public IBrush ButtonHoverColor
    {
        get => GetValue(ButtonHoverColorProperty);
        set => SetValue(ButtonHoverColorProperty, value);
    }

    public Card()
    {
        InitializeComponent();
    }
}
