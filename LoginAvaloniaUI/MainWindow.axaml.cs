using Avalonia.Controls;
using LoginAvaloniaUI.ViewModels;

namespace LoginAvaloniaUI
{
    public partial class MainWindow : Window
    {
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainWindowViewModel();
    }
}
}
