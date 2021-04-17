using DevLibrary.Application.Services.Implementations;
using DevLibrary.Application.Services.Interfaces;
using DevLibrary.Infra.Persistence.Persistence;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace DevLibrary.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {           

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "DevLibrary.API", Version = "v1" });
            });

            //var connectionString = Configuration.GetConnectionString("DevLibrary"); // USO DO BANCO SQL SERVER PRÓPRIO DO VISUAL STUDIO
            //services.AddDbContext<DevLibraryDbContext>(options => options.UseSqlServer(connectionString));

            services.AddDbContext<DevLibraryDbContext>(opt => opt.UseInMemoryDatabase("Database")); // USO DO BANCO EM MEMÓRIA => BAIXAR O PACOTE EntityFrameworkCore.InMemory
            services.AddScoped<DevLibraryDbContext, DevLibraryDbContext>();


            services.AddScoped<ILocacao, LocacaoService>();
            services.AddScoped<IRegistroATA, RegistroATAService>();
            services.AddScoped<ICategoria, CategoriaService>();
            services.AddScoped<IAluno, AlunoService>();
            services.AddScoped<ILivro, LivroService>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "DevLibrary.API v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
