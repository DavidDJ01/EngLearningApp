namespace EnglishLearningApp
{

    public class StartUp
    {
        public void Configure(IApplicationBuilder app)
        {
            app.UseAuthentication();
            
            app.UseRouting();

            app.UseStaticFiles();

            app.UseEndpoints(endpoint =>
            {
                endpoint.MapRazorPages();

                endpoint.MapGet("/test", async app =>
                {
                    await app.Response.WriteAsync("Hello");
                });

                
            });
           
        }

        public void ConfigureServices(IServiceCollection services)
        {   
            services.AddControllers();

            services.AddRazorPages();
            // Thực hiện các tùy chỉnh và trả về IServiceProvider
           /* return services.BuildServiceProvider();*/

        }

    }
}
