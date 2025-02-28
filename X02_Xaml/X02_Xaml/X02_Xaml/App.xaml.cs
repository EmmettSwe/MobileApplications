using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace X02_Xaml
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new MainPage();
            //you can interact with the pages element by first finding them then modifying their properties, though usually it is best to do ths in the ages code behind
            
            /*var Label = MainPage.FindByName<Label>("lblResult");
            var Btn = MainPage.FindByName<Button>("btnClick");

            
            Btn.Clicked += (s, e) =>
            {
                Label.Text = "This is clicked on the other method";
                MainPage.BackgroundColor = Color.Beige;
            };*/



            //Create each of the elements, then add the label and button to the stack 
            /*StackLayout stackLayout = new StackLayout { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center };

            Label lblResult = new Label { Text = "Clicked zeee buton" };
            Button btnResult = new Button { Text = "Click meee" };



            stackLayout.Children.Add(lblResult);
            stackLayout.Children.Add(btnResult);


            btnResult.Clicked += (sender, e) =>
            {
                lblResult.Text = "Clicked the butttton ";
                MainPage.BackgroundColor = Color.AliceBlue;

            };

            MainPage = new ContentPage { Content = stackLayout };*/

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
