using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace X05_Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OurPage : ContentPage
    {
        private static int count = 1;
        public OurPage()
        {
            InitializeComponent();

            btnNew.Clicked += (sender, e) => { Navigation.PushAsync(new OurPage()); };
            btnNewModal.Clicked += (sender, e) => { Navigation.PushModalAsync(new OurPage()); };
            btnClose.Clicked += (sender, e) => { Navigation.PopAsync(); };
            btnCloseModal.Clicked += (sender, e) => { Navigation.PopModalAsync(); };
            btnGoToRoot.Clicked += (sender, e) => { Navigation.PopToRootAsync(); };

            Title = "Page uhhhh " + count++;
        }
    }
}