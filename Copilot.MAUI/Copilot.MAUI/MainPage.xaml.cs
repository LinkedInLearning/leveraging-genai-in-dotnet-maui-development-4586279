
using Copilot.MAUI.ViewModels;

namespace Copilot.MAUI
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            // Assuming "button" is your Button instance
            CounterBtn.Clicked += async (s, e) =>
            {
                // Make the button smaller
                await CounterBtn.ScaleTo(0.8, 250);

                // Make the button larger
                await CounterBtn.ScaleTo(1.2, 250);

                // Snap the button back to its original size
                await CounterBtn.ScaleTo(1, 500);
            };

        }

        protected override async void OnAppearing()
        {
#if ANDROID
            var status = await Permissions.RequestAsync<Permissions.LocationWhenInUse>();
#endif
            base.OnAppearing();
        }
    }

}
