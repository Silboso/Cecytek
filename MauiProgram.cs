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
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            //Cadena conexion PostgreSQL
            string CadenaPostGreSQL = "Host=ep-solitary-flower-a53pkk73-pooler.us-east-2.aws.neon.tech;Port=5432;Database=Cecytek;Username=gr200110536;Password=0GVkKlc4bCFH;sslmode=require";


            builder.Services.AddDbContext<CecytekContext>(options =>
            {
                options.UseNpgsql(CadenaPostGreSQL);

            });

            builder.Services.AddMauiBlazorWebView();

#if DEBUG
    		builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddBlazorBootstrap();
            return builder.Build();
        }
    }
}
