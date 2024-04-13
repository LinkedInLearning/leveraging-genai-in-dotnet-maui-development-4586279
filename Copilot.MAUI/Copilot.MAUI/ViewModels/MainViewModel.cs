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

        private double _Price;
        public double Price
        {
            get => _Price;
            set
            {
                if (_Price == value)
                    return;
                _Price = value;
                OnPropertyChanged(nameof(Price));
            }
        }
    }
}
