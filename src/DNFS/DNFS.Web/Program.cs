using DNFS.Core.Modulos.Estado;
using DNFS.Core.Modulos.Modal;
using DNFS.Core.Modulos.Numeros;
using DNFS.Core.Modulos.ParametrosArbitrarios;
using DNFS.Core.Modulos.Tabela;
using DNFS.Core.Modulos.Tarefas;
using DNFS.Web.Modulos.Estado;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace DNFS.Web
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.Services.AddTransient<TarefaListPageViewModel>();
            builder.Services.AddTransient<NumeroListPageViewModel>();
            builder.Services.AddTransient<TabelaPageViewModel>();
            builder.Services.AddTransient<ParametroArbPageViewModel>();
            builder.Services.AddTransient<ModalPageViewModel>();
            builder.Services.AddSingleton<EstadoViewModel>();            
            builder.Services.AddSingleton<StateContainer>();
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            await builder.Build().RunAsync();
        }
    }
}
