using Cecytek.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Cecytek
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            //Cadena conexion PostgreSQL
            string CadenaPostGreSQL = "Host=localhost;Port=5432;Database=CECYTEK;Username=postgres;Password=123";

            builder.Services.AddDbContext<CecytekContext>(options =>
            {
                options.UseNpgsql(CadenaPostGreSQL);

            });

            builder.Services.AddMauiBlazorWebView();

#if DEBUG
    		builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
