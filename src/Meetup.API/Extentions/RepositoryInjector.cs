using Meetup.Domain.Interfaces.Repositories;
using Meetup.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Meetup.API.Extentions
{
    public static class RepositoryInjector
    {
        public static void RegisterRepositories(this IServiceCollection services)
        {
            services.AddScoped<ITagRepository, TagRepository>();
            services.AddScoped<IMeetingRepository, MeetingRepository>();
            services.AddScoped<IMeetingTypeRepository, MeetingTypeRepository>();
            services.AddScoped<ILocationRepository, LocationRepository>();
        }
    }
}
