using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace X08_Database
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
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
    public interface IFileHelper
    {
        string GetLocalFilePath(string filename);
    }

}
