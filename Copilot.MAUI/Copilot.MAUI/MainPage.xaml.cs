
using Copilot.MAUI.ViewModels;

namespace Copilot.MAUI
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
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
