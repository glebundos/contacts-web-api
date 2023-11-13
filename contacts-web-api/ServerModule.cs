using contacts_web_api.Application.Handlers;
using contacts_web_api.Core.Repositories;
using contacts_web_api.Core.Repositories.Base;
using contacts_web_api.Infrastructure.Data;
using contacts_web_api.Infrastructure.Repositories;
using contacts_web_api.Infrastructure.Repositories.Base;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System.Reflection;

namespace contacts_web_api
{
    public static class ServerModule
    {
        public static void ConfigureServices(this IServiceCollection services)
        {
            var builder = WebApplication.CreateBuilder();
            services.AddControllers().AddJsonOptions(
            o =>
            {
                o.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles;
            });

            services.AddEndpointsApiExplorer();
            var connectionString = builder.Configuration.GetConnectionString("Contacts.Data");
            services.AddDbContext<ContactsContext>(m => m.UseSqlServer(connectionString));
            services.AddSwaggerGen(c => {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Contacts.API",
                    Version = "v1"
                });
            });

            services.AddCors();
            services.AddAutoMapper(typeof(Program));
            services.AddMediatR(typeof(GetAllContactsHandler).GetTypeInfo().Assembly);
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            services.AddTransient<IContactRepository, ContactRepository>();
            services.AddTransient<IJobRepository, JobRepository>();
        }
    }
}
