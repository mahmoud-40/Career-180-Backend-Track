
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using ProductMangement_API.Models;
using ProductMangement_API.UnitOfWorks;

namespace ProductMangement_API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(
                c =>
                {
                    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Product Management API",
                        Version = "v1",

                        Description = "This is a simple CRUD API for Product Management",
                        Contact = new OpenApiContact
                        {
                            Name = "Mahmoud Abdulmawlaa",
                            Email = "mahmoud@gmail.com"
                        }
                    });
                    c.EnableAnnotations();
                }
            );
            builder.Services.AddDbContext<StoreContext>(op => op.UseLazyLoadingProxies().UseSqlServer(builder.Configuration.GetConnectionString("StoreCon")));
            builder.Services.AddScoped<UnitOfWork>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            //if (app.Environment.IsDevelopment())
            //{

            //}

            app.UseSwagger();
            app.UseSwaggerUI();

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
