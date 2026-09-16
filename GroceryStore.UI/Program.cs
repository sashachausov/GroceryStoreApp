using GroceryStore.Application.Interfaces;
using GroceryStore.Application.Services;
using GroceryStore.Infrastructure.Persistence.Json;
using GroceryStore.UI.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace GroceryStore.UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //System.Windows.Forms.Application.Run(new Form1());

            var services = new ServiceCollection();

            services.AddSingleton<ICategoryRepository, JsonCategoryRepository>();
            services.AddSingleton<CategoryService>();

            services.AddSingleton<IProductRepository, JsonProductRepository>();
            services.AddSingleton<ProductService>();

            services.AddSingleton<ProductsForm>();
            services.AddSingleton<CategoriesForm>();
            services.AddSingleton<Form1>();

            var provider = services.BuildServiceProvider();
            System.Windows.Forms.Application.Run(provider.GetRequiredService<CategoriesForm>());
        }        
    }
}