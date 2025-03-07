using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace X05_Navigation
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Title = "Dogshit AI bloat trash";
            btnNew.Clicked += (sender, e) => { Navigation.PushAsync(new OurPage());  };
            btnNewModal.Clicked += (sender, e) => { Navigation.PushModalAsync(new OurPage());  };

        }
    }
}
