using Microsoft.Maui.Layouts;

namespace FlexLayoutBugSample;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        Content = new FlexLayout
        {
            Direction = FlexDirection.Row,
            Wrap = FlexWrap.Wrap,
            // AlignContent = FlexAlignContent.Center,
            Children =
            {
                new Label
                {
                    Text = "Welcome to",
                    BackgroundColor = Colors.DarkBlue
                },
                new Image { Source = "dotnet_bot.png" },
                new Label
                {
                    Text = ".NET MAUI",
                    BackgroundColor = Colors.DarkOliveGreen
                }
            }
        };
    }
}