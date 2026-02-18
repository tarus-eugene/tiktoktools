using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Storage;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TikTokTools.Services.Config;
using TikTokTools.Data;

namespace TikTokTools
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var configBuilder = new ConfigurationBuilder().AddJsonFile("DbConfig.json", optional: false, reloadOnChange: true);
            var configuration = configBuilder.Build();
            var builder = MauiApp.CreateBuilder();

            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("InterVariable.ttf", "Inter");
                });

            builder.Services.AddMauiBlazorWebView();
            builder.Services.AddSingleton<IFolderPicker>(FolderPicker.Default);
            builder.Services.AddSingleton(configuration);
            builder.Services.AddScoped<IConfigService, ConfigService>();
            builder.Services.AddDbContextPool<Context>(options =>
                options.UseSqlite("Data Source=persistence.db")
             );

#if DEBUG
                builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
