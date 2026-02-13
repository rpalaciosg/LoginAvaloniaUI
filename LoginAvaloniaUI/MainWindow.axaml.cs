using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using LoginAvaloniaUI.Services;
using LoginAvaloniaUI.ViewModels;

namespace LoginAvaloniaUI
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var appLifetimeService = new AppLifetimeService();
            DataContext = new MainWindowViewModel(appLifetimeService);
        }

        //private void ExitButton_Click(object? sender, RoutedEventArgs e)
        //{
        //    if (Application.Current?.ApplicationLifetime is Avalonia.Controls.ApplicationLifetimes.IClassicDesktopStyleApplicationLifetime desktop)
        //    {
        //        desktop.Shutdown(); // termina toda la app
        //    }
        //    else
        //    {
        //        Close(); //fallback
        //    }
        //}
}
}
