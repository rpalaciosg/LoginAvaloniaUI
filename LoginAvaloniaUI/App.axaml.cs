using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Avalonia.Media;

namespace LoginAvaloniaUI
{
    public partial class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);

            // esto muestra border de todos los contenderes solo para depuracion luego borrar                        
            //RenderOptions.SetTextRenderingMode(this, TextRenderingMode.SubpixelAntialias);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                desktop.MainWindow = new MainWindow();
                // Habilita devtools - para debug UI
                desktop.MainWindow.AttachDevTools();
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}