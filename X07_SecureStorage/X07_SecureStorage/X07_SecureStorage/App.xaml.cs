using System;
using System.Globalization;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace X07_SecureStorage
{
    public partial class App : Application
    {
        bool lightOn;
        Switch lightSwitch;
        async void isLightOn()
        {
            string result = await SecureStorage.GetAsync("light");
            if (result != null)
            {
                lightOn = result.Equals("false") ? false : true;
            }
            else
            {
                await SecureStorage.SetAsync("light", "false"); // give it an initail value if there is non set yet
            }
        }



        public App()
        {
            InitializeComponent();
            lightSwitch = new Switch { IsToggled = lightOn };
            Label label = new Label { Text = "Light Switch" };
            isLightOn(); // deternine the state of the saved light

            lightSwitch.IsToggled = lightOn;


            lightSwitch.Toggled += (sender, e) =>
            {
                if (lightSwitch.IsToggled)
                {
                    SecureStorage.SetAsync("light", "true");
                }
                else
                {
                    SecureStorage.SetAsync("light", "false");
                }
            };

            MainPage = new ContentPage
            {
                Content = new StackLayout
                {
                    HorizontalOptions = LayoutOptions.CenterAndExpand,
                    VerticalOptions = LayoutOptions.CenterAndExpand,
                    Children = { label, lightSwitch }
                }
            };


            MainPage.BindingContext = lightSwitch;

            MainPage.SetBinding(VisualElement.BackgroundColorProperty, "IsToggled", converter: new ToggledToColorConverter());


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


    public class ToggledToColorConverter : IValueConverter //This class covertes a true/false to a color 
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (bool)value ? Color.DarkSalmon : Color.Magenta;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
