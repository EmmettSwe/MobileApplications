using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace X05_Navigation
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());

            //add a toolbar button and text 
            ToolbarItem tb = new ToolbarItem { Text="Meowwww" };
            tb.Clicked += (sender, e) => { MainPage.Navigation.PopToRootAsync(); };
            MainPage.ToolbarItems.Add(tb);
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
