using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;
using System;

namespace LoginAvaloniaUI.Controls;

public partial class CustomButton : UserControl
{
    public static readonly StyledProperty<string> TextProperty = AvaloniaProperty.Register<CustomButton, string>(nameof(Text), defaultValue:"Bot�n");

    //public static readonly StyledProperty<IBrush> BackgroundColorProperty = AvaloniaProperty.Register<CustomButton, IBrush>(nameof(BackgroundColor), Brushes.DodgerBlue);
    public static readonly StyledProperty<IBrush> BackgroundColorProperty = AvaloniaProperty.Register<CustomButton, IBrush>(nameof(BackgroundColor), defaultValue: new SolidColorBrush(Color.Parse("#2196F3")));

    public static readonly StyledProperty<IBrush> HoverColorProperty =
            AvaloniaProperty.Register<CustomButton, IBrush>(nameof(HoverColor),
                defaultValue: new SolidColorBrush(Color.Parse("#1976D2")));

    public static readonly StyledProperty<StreamGeometry> IconProperty = AvaloniaProperty.Register<CustomButton, StreamGeometry>(nameof(Icon));

    public string Text
    {
        get => GetValue(TextProperty);
        set => SetValue(TextProperty, value);
    }

    public IBrush BackgroundColor
    {
        get => GetValue(BackgroundColorProperty);
        set => SetValue(BackgroundColorProperty, value);
    }

    public IBrush HoverColor
    {
        get => GetValue(HoverColorProperty);
        set => SetValue(HoverColorProperty, value);
    }

    public StreamGeometry Icon
    {
        get => GetValue(IconProperty);
        set => SetValue(IconProperty, value);
    }

    public CustomButton()
    {
        InitializeComponent();
    }

    //private void InitializeComponent()
    //{
    //    throw new NotImplementedException();
    //}
}
