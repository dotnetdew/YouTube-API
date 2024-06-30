using Microsoft.Extensions.DependencyInjection;
using YouTubeApi.Application.Interfaces.AutoMapper;
namespace YouTubeApi.Mapper
{
    public static class Registration
    {
        public static void AddCustomMapper(this IServiceCollection services)
        {
            services.AddSingleton<IMapper, AutoMapper.Mapper>();
        }
    }
}
