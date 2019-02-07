using Prism;
using Prism.Ioc;
using MinhaCelula.ViewModels;
using MinhaCelula.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Prism.DryIoc;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace MinhaCelula
{
    public partial class App : PrismApplication
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("LoginPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<MainPage>();
            containerRegistry.RegisterForNavigation<LoginPage>();
            containerRegistry.RegisterForNavigation<CelulasPage>();
            containerRegistry.RegisterForNavigation<ReportsPage>();
            containerRegistry.RegisterForNavigation<ChurchsPage>();
        }
    }
}
