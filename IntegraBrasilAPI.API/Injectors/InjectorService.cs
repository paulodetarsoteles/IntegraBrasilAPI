using IntegraBrasilAPI.API.Mappings;
using IntegraBrasilAPI.API.Rest;
using IntegraBrasilAPI.API.Rest.Interfaces;
using IntegraBrasilAPI.API.Services;
using IntegraBrasilAPI.API.Services.Interfaces;

namespace IntegraBrasilAPI.API.Injectors
{
    public static class InjectorService
    {
        public static void Configure(IServiceCollection services)
        {
            #region Mappings

            services.AddAutoMapper(typeof(EnderecoMapping));
            services.AddAutoMapper(typeof(BancoMapping));

            #endregion

            #region Services

            services.AddScoped<IBrasilApiRest, BrasilApiRest>();
            services.AddScoped<IEnderecoService, EnderecoService>();
            services.AddScoped<IBancoService, BancoService>();

            #endregion
        }
    }
}
