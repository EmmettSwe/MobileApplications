using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace X01_Intro
{
    public partial class App : Application
    {
        public static Size ScreenSize;
        public static Label label;

        const int padding = 10;
        const int spacing = 5;
        const int count = 5;

        public App()
        {
            InitializeComponent();
            label = new Label { Text = "Size will go here" };
            //MainPage = new ContentPage { Content = label };

            // calculating how big each box will be 
            var boxSize = (ScreenSize.Width - 2 * padding + spacing) / count - spacing;
            MainPage = new ContentPage
            {
                Content = new ColorGrid(boxSize, count, count) { RowSpacing = spacing, ColumnSpacing = spacing, VerticalOptions = LayoutOptions.CenterAndExpand },
                Padding = padding
            };

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

    public class ColorGrid : Grid
    {
        public ColorGrid(double boxSize, int rows, int columns)
        {
            //Loop within a loop to ceate a grid of boxViews of different colors


            for (var row = 0; row < rows; row++)
            {
                for (var col = 0; col < columns; col++)
                {
                    var box = new BoxView
                    {
                        Color = Color.FromRgb(row * 256 / rows, col * 256 / columns, 127),
                        WidthRequest = boxSize,
                        HeightRequest = boxSize,

                    };
                    Children.Add(box, row, col);
                }
            }

        }
    }
}
