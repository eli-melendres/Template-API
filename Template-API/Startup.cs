using Microsoft.AspNetCore.Builder;

namespace Template_API
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services) 
        {
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Configure the HTTP request pipeline.
            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            //app.UseCors();
            app.UseRouting();

            app.UseAuthorization();
            //app.UseAuthentication();

            app.UseEndpoints(endpoints => endpoints.MapControllers());
        }
    }
}
