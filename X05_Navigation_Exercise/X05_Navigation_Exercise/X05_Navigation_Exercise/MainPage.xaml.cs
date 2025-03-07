using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace X05_Navigation_Exercise
{
    public partial class MainPage : ContentPage
    {
        private static Person[] people = new Person[3];
        public MainPage()
        {
            InitializeComponent();
            people[0] = new Person("JOE", "");
            people[1] = new Person("JANE", "");
            people[2] = new Person("JENNY", "");

            lbl1.Clicked += (sender, e) => { Navigation.PushModalAsync( new DisplayInfo(lbl1.Text));  };
            lbl2.Clicked += (sender, e) => { Navigation.PushModalAsync( new DisplayInfo(lbl2.Text));  };
            lbl3.Clicked += (sender, e) => { Navigation.PushModalAsync( new DisplayInfo(lbl3.Text));  };

            lbl11.Clicked += (sender, e) => { Navigation.PushModalAsync(new DisplayInfo(people[0])); };
            lbl22.Clicked += (sender, e) => { Navigation.PushModalAsync(new DisplayInfo(people[1])); };
            lbl33.Clicked += (sender, e) => { Navigation.PushModalAsync(new DisplayInfo(people[2])); };

            changes.Clicked += (sender, e) =>
            {
                for (int i = 0; i < people.Length; i++)
                {
                    if (i == 0)
                    {
                        lbl11.Text = people[i].fName + " " + people[i].lName;
                    }
                    else if (i == 1) { 
                        lbl22.Text = people[i].fName + " " + people[i].lName;
                    }
                    else
                    {
                        lbl33.Text = people[i].fName + " " + people[i].lName;
                    }
                }
            };
                                
        }
    }
}
