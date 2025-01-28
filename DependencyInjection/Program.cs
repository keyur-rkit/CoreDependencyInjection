using DependencyInjection.Services;

namespace DependencyInjection
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddTransient<ITransientService, TransientService>();
            builder.Services.AddScoped<IScopedService,ScopedService>();
            builder.Services.AddSingleton<ISingletonService,SingletonService>();

            // Register services with appropriate lifetimes
            builder.Services.AddSingleton<IGuidGenerationService, GuidGenerationService>();  // Singleton service
            builder.Services.AddScoped<IBookService, DatabaseService>();  // Scoped service
            //builder.Services.AddTransient<IBookService, InMemoryService>();  // Transient service

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}