using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Copilot.MAUI.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private string _Name;
        public string Name
        {
            get => _Name;
            set
            {
                if (_Name == value)
                    return;
                _Name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        private double _Latitude;
        public double Latitude
        {
            get => _Latitude;
            set
            {
                if (_Latitude == value)
                    return;
                _Latitude = value;
                OnPropertyChanged(nameof(Latitude));
            }
        }

        private double _Longitude;
        public double Longitude
        {
            get => _Longitude;
            set
            {
                if (_Longitude == value)
                    return;
                _Longitude = value;
                OnPropertyChanged(nameof(Longitude));
            }
        }

        private Command? _GetLocation;
        public Command GetLocation 
        { 
            get
            {
                return _GetLocation ??= new Command(async () => await GetLocationAsync());
            }
        }

        public async Task GetLocationAsync()
        {
            try
            {
                var location = await Geolocation.GetLastKnownLocationAsync();

                if (location != null)
                {
                    Latitude = location.Latitude;
                    Longitude = location.Longitude;
                }
            }
            catch (Exception ex)
            {
                await MainThread.InvokeOnMainThreadAsync(async () =>
                {
                    await Application.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
                });
            }
        }

        private Command? _ThemeChanger;
        public Command ThemeChanger
        {
            get
            {
                return _ThemeChanger ??= new Command(async () => await Shell.Current.GoToAsync(""));
            }
        }
    }
}
