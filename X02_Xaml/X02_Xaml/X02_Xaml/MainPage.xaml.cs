using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace X02_Xaml
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            //Can access all named elements
            //This approch is preferred when interacting wiht a pages xaml interface, rather thean putting code in app.xaml.cs

            /*btnClick.Clicked += (sender, e) => {
                lblResult.Text = "You clicked the fucking button";
                this.BackgroundColor = new Color(255, 0, 255);
            };*/

            btnClick.Clicked += (sender, e) =>
            {
                switch (operation.Items[operation.SelectedIndex])
                {
                    case "Multiply":
                        Output.Text = (Convert.ToDouble(Input1.Text) * Convert.ToDouble(Input2.Text)).ToString();
                        break;
                    case "Divide":
                        Output.Text = (Convert.ToDouble(Input1.Text) / Convert.ToDouble(Input2.Text)).ToString();
                        break;
                    case "Add":
                        Output.Text = (Convert.ToDouble(Input1.Text) + Convert.ToDouble(Input2.Text)).ToString();
                        break;
                    case "Subtract":
                        Output.Text = (Convert.ToDouble(Input1.Text) - Convert.ToDouble(Input2.Text)).ToString();
                        break;
                }
            };
        }
    }
}
