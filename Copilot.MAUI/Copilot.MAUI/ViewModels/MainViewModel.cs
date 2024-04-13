using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
