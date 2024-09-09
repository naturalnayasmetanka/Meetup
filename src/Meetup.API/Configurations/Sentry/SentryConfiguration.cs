using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace Meetup.API.Configurations.Sentry
{
    public static class SentryConfiguration
    {
        public static IHostBuilder ConfigureWebHostWithSentry(this IHostBuilder builder)
        {
            return builder.ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseSentry(o =>
                {
                    o.Dsn = "https://adb0b8abbb2f783bfc848475ade6c155@o4507921863671808.ingest.de.sentry.io/4507921867341904";
                    o.Debug = true;
                    o.TracesSampleRate = 1.0;
                });
            });
        }
    }
}
