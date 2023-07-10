namespace API.Extensions;

public static class ApplicationServiceExtension
{
    public static void ConfigureCors(this IServiceCollection services) =>
        services.AddCors(options =>
        {
            options.AddPolicy("CorsPolicy", builder =>
                builder.AllowAnyOrigin()    // De lo contrario, especificar con: WithOrigins("https://domini.com")
                .AllowAnyMethod()           // De lo contrario, especificar con: WithMethods(*GET", "POST")
                .AllowAnyHeader());         // De lo contrario, especificar con: WithHeaders(*accept*, "content-type")
        });

}
