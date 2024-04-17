using EventBus.Base.Abstraction;
using EventBus.Base;
using EventBus.Factory;
using RabbitMQ.Client;

namespace PaymentService.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var env = builder.Environment;

            // Configuration
            builder.Configuration
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("Configurations/appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"Configurations/appsettings.{env.EnvironmentName}.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables();

            // Serilog Configuration
            //Log.Logger = new LoggerConfiguration()
                //.ReadFrom.Configuration(builder.Configuration)
                //.CreateLogger();

            // Services
            builder.Services.AddControllers();
            builder.Services.AddSwaggerGen();
            //builder.Services.AddLogging(loggingBuilder => loggingBuilder.AddSerilog(dispose: true));

            // Event Bus Configuration
            builder.Services.AddSingleton<IEventBus>(sp =>
            {
                EventBusConfig config = new()
                {
                    ConnectionRetryCount = 5,
                    EventNameSuffix = "IntegrationEvent",
                    SubscriberClientAppName = "PaymentService",
                    EventBusType = EventBusType.RabbitMQ,
                    Connection = new ConnectionFactory()
                    {
                        HostName = "localhost",
                        Port = 15672,
                        UserName = "guest",
                        Password = "guest"
                    }
                };

                return EventBusFactory.Create(config, sp);
            });

            var app = builder.Build();

            // Middleware
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "PaymentService.Api v1"));
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();

            app.MapControllers();

            //Log.Information("Application is Running....");

            app.Run();
        }
    }
}