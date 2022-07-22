using KeyBoard.Interfaces;
using KeyBoard.Services.Factories;
using KeyBoard.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows;

namespace KeyBoard
{
    public partial class App : Application
    {
        private readonly IServiceProvider _serviceProvider;

        public App()
        {
            ServiceCollection services = new ServiceCollection();
            ConfigureServices(services);
            _serviceProvider = services.BuildServiceProvider();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            MainWindow = _serviceProvider.GetRequiredService<MainWindow>();
            MainWindow.Show();
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddTransient<IKeysFactory, RusKeyFactory>();

            services.AddSingleton<MainViewModel>();

            services.AddSingleton(s => new MainWindow()
            {
                //DataContext = s.GetRequiredService<MainViewModel>()
            });
        }
    }
}
