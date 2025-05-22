using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetApiTemplate.Data;
using Microsoft.EntityFrameworkCore;
using Npgsql.Replication;

namespace AspNetApiTemplate.Extensions;

public static class MigrationsExtensions
{
    public static WebApplication MigrateDatabase(this WebApplication app)
    {
        // Run pending EF Core migrations automatically on startup
        using (var scope = app.Services.CreateScope())
        {
            var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
            db.Database.Migrate();
        }

        return app;
    }
}
