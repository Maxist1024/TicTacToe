using Castle.Windsor;
using Castle.Windsor.Installer;
using System.Windows;

namespace TicTacToe.UI
{
    /// <summary>
    /// Logika interakcji dla klasy App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            var container = new WindsorContainer();
            container.Install(FromAssembly.This());


            MainWindow window = container.Resolve<MainWindow>();
            window.Show();

            container.Release(window);
        }
    }
}
