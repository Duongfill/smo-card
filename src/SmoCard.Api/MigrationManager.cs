using Microsoft.EntityFrameworkCore;
using SmoCard.Data;

namespace SmoCard.Api
{
    public static class MigrationManager
    {
        public static WebApplication MigrateDatabase(this WebApplication app)
        {
            using(var scope = app.Services.CreateScope())
            {
                using (var context = scope.ServiceProvider.GetRequiredService<SmoCardContext>())
                {
                    context.Database.Migrate();
                    new DataSeeder().SeedAsync(context).Wait();
                }
            }
            return app;
        }
    }
}
