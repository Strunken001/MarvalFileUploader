using Application.Repositories;
using Domain.Db;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Application.DI;

public static class ApplicationService
{
    public static IServiceCollection AddApplicationService(this IServiceCollection services, IConfiguration config)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddMediatR(Assembly.GetExecutingAssembly());
        services.AddDbContext<FileUploadContext>(options => options.UseSqlServer(config.GetConnectionString("DefaultConnection")));
        services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));
        return services;
    }
}
