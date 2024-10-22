using Meetup.Application.Interfaces;
using Meetup.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Meetup.API.Extentions
{
    public static class ServiceInjector
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<ITagService, TagService>();
            services.AddScoped<IMeetingService, MeetingService>();
            services.AddScoped<ILocationService, LocationService>();
            services.AddScoped<IMeetingTypeService, MeetingTypeService>();
        }
    }
}
