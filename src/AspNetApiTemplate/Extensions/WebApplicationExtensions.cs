using Scalar.AspNetCore;

namespace AspNetApiTemplate.Extensions
{
    public static class WebApplicationExtensions
    {
        public static WebApplication UseServices(this WebApplication app)
        {
            if (app.Environment.IsDevelopment())
            {
                app.MapScalarApiReference();
                app.MapOpenApi();
            }

            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();

            return app;
        }
    }
}