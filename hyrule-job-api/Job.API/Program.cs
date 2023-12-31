using AutoMapper;
using Job.Data;
using Job.Services.AutoMapper;

namespace Job.API
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
            builder.Services.AddSwaggerGen();
            builder.Services.AddCors(options =>
            {
                options.AddDefaultPolicy(builder =>
                {
                    builder.WithOrigins("https://localhost:3200")
                           .WithHeaders("X-API-Vesrion");
                });
            });

            builder.Services.AddDbContext<JobContext>(options =>{});

            //HttpContextAccessor
            builder.Services.AddHttpContextAccessor();
            builder.Services.AddHttpClient();


            //Auto Mapper
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<ServiceModelsMap>();
            });
            builder.Services.AddSingleton<AutoMapper.IConfigurationProvider>(config);
            builder.Services.AddSingleton<IMapper>(sp => new Mapper(config, sp.GetService));


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.UseCors();
            app.MapControllers();

            app.Run();
        }
    }
}
