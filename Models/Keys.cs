using KeyBoard.Commands;
using KeyBoard.Core;
using System;
using System.Collections.Generic;

namespace KeyBoard.Models
{
    public class Keys : ObservableObject
    {
        private string _name;

        public string Name
        {
            get => Upper ? _name.ToString().ToUpper() : _name.ToString().ToLower();
            set => Set(ref _name, value);
        }

        private bool _upper = false;
        public bool Upper
        {
            get => _upper;
            set { Set(ref _upper, value); OnPropertyChanged(nameof(Name)); }
        }

        public event Action<Keys> KeyPressed;

        private RelayCommand _keyCommand = null;

        public RelayCommand KeyCommand => _keyCommand ?? (_keyCommand = new RelayCommand(Handler));

        public void Handler(object o)
        {
            KeyPressed?.Invoke(this);
        }

        public Keys()
        {
            Name = _name;
        }

        public static void UpperKeys(IEnumerable<Keys> keys, bool wantUpper)
        {
            if(!wantUpper)
            {
                foreach (var item in keys)
                {
                    item.Upper = false;
                    if (item.Name == "_") item.Name = "-";
                }
            }
            else
            {
                foreach (var item in keys)
                {
                    item.Upper = true;
                    if (item.Name == "-") item.Name = "_";
                }
            }
        }
    }
}
