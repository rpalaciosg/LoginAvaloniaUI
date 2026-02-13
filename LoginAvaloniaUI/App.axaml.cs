using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using System.Globalization;

namespace LoginAvaloniaUI
{
    public partial class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);

            // esto muestra border de todos los contenderes solo para depuracion luego borrar                        
            //RenderOptions.SetTextRenderingMode(this, TextRenderingMode.SubpixelAntialias);

            // Configurar cultura a español
            CultureInfo.CurrentCulture = new CultureInfo("es-ES");
            CultureInfo.CurrentUICulture = new CultureInfo("es-ES");
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