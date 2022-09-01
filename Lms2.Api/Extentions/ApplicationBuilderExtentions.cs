using Lms2.Data.Data;

namespace Lms2.Api.Extentions
{
    public static class ApplicationBuilderExtentions
    {
        public static async Task<IApplicationBuilder> SeedDataAsync(this IApplicationBuilder app)
        {
            using(var scope = app.ApplicationServices.CreateScope())
            {
                var serviceProvider = scope.ServiceProvider;
                var db = serviceProvider.GetRequiredService<Lms2ApiContext>();

            try
            {
                await SeedData.InitAsync(db); 
            }
            catch(Exception ex) 
            {
            }
            }
            return app;
        }
    }
}
