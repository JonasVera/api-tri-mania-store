using Api.Domain.Interfaces.Services.Category;
using Api.Domain.Interfaces.Services.Product;
using Api.Domain.Interfaces.Services.User;
using Api.Service.Services; 
using Microsoft.Extensions.DependencyInjection;

namespace Api.CrossCutting.DependencyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependencyService (IServiceCollection serviceCollection) {
            serviceCollection.AddTransient<IUserService, UserService>(); 
            serviceCollection.AddTransient<ILoginService, LoginService>();
            
            serviceCollection.AddTransient<ICategoryService, CategoryService>();
            serviceCollection.AddTransient<IProductService, ProductService>();
        }
    }
}
