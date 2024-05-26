
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

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        override protected async void OnAppearing()
        {
            await RequestLocationPermissionAsync();

            base.OnAppearing();

        }

        public async Task RequestLocationPermissionAsync()
        {
            var status = await Permissions.CheckStatusAsync<Permissions.LocationWhenInUse>();

            if (status != PermissionStatus.Granted)
            {
                status = await Permissions.RequestAsync<Permissions.LocationWhenInUse>();
            }

            if (status != PermissionStatus.Granted)
            {
                // Permission was not granted, notify the user.
                // You might want to update your UI to reflect this.
            }
        }

}

}
