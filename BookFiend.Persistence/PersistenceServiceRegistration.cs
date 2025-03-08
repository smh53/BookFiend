using BookFiend.Application.Contracts.Persistence;
using BookFiend.Persistence.DatabaseContext;
using BookFiend.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BookFiend.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BookFiendDatabaseContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IAuthorRepository, AuthorRepository>();
            services.AddScoped<IBookRepository, BookRepository>();
            return services;
        }
    }
}
