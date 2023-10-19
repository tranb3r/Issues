using ClassLibrary1;
using ClassLibrary2;

namespace MauiAppBabel103
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>();

            builder.Services.AddTransient<IMyViewModel, MyViewModel>();

            return builder.Build();
        }
    }
}
