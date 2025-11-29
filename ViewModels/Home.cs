using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace WeatherApp.ViewModels
{
    public class Home : INotifyPropertyChanged
    {
        private string? _Name;

        private string? _Greeting;

        public string? Name
        {
            get
            {
                return _Name;
            }
            set
            {
                if (_Name != value)
                {
                    _Name = value;
                    RaisePropertyChanged();
                    RaisePropertyChanged(nameof(Greeting));
                }
            }
        }

        public string? Greeting
        {
            get
            {
                if (string.IsNullOrEmpty(Name))
                {
                    return "Hello Default User!";
                }
                else
                {
                    return $"Hello {Name}!";
                }
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void RaisePropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
