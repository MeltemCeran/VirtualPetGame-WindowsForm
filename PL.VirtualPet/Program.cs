using AutoMapper;
using BLL.VirtualPet.Profiles.Concrete;
using Microsoft.Extensions.DependencyInjection;
namespace PL.VirtualPet
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
            Application.Run(new Form1());

            var services = new ServiceCollection();

            // AutoMapper'ý tanýtma
            services.AddAutoMapper(typeof(PetProfile)); // PetProfile'ý tanýtýyoruz

            // Diðer servis eklemeleri...

            var serviceProvider = services.BuildServiceProvider();
        }
    }
}