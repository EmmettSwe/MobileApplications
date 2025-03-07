using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace X05_Navigation_Exercise
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DisplayInfo : ContentPage
    {
        public DisplayInfo()
        {

        }
        public DisplayInfo(string fName) : this()
        {
            InitializeComponent();
       
            lblDisp.Text = fName;


            GoBack.Clicked += (sender, e) => { Navigation.PopModalAsync();  };
        }
        public DisplayInfo(Person person) : this()
        {
            InitializeComponent();
            person.lName = "Changed";
            GoBack.Clicked += (sender, e) => { Navigation.PopModalAsync(); };
        }
    }
}