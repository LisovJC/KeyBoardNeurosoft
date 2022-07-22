using KeyBoard.Commands;
using KeyBoard.Interfaces;
using KeyBoard.Models;
using System;
using System.Collections.Generic;

namespace KeyBoard.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private string _text;
        public string Text
        {
            get => _text;
            set => Set(ref _text, value);
        }

        public event Action<Keys> KeyPressed;       

        public IEnumerable<Keys> Row0 { get; set; }

        public IEnumerable<Keys> Row1 { get; set; }

        public IEnumerable<Keys> Row2 { get; set; }

        public IEnumerable<Keys> Row3 { get; set; }

        public IEnumerable<Keys> Row4 { get; set; }

        public MainViewModel(IKeysFactory factory)
        {            
            Row0 = factory.FillingZeroRow();
            Row1 = factory.FillingFirstRow();
            Row2 = factory.FillingSecondRow();
            Row3 = factory.FillingThridRow();
            Row4 = new List<Keys>
            {
                new Keys() {Name = "-"},
                new Keys() {Name = ","},
                new Keys() {Name = " "},
                new Keys() {Name = "."},
                new Keys() {Name = "<="}
            };
            

            foreach (var item in Row0)
            {
                item.KeyPressed += Item_KeyPressed;
            }

            foreach (var item in Row1)
            {
                item.KeyPressed += Item_KeyPressed;
            }

            foreach (var item in Row2)
            {
                item.KeyPressed += Item_KeyPressed;
            }

            foreach (var item in Row3)
            {
                item.KeyPressed += Item_KeyPressed;
            }

            foreach (var item in Row4)
            {
                item.KeyPressed += Item_KeyPressed;
            }
        }

        private void Item_KeyPressed(Keys obj)
        {
            if (obj.Name == "shift" && !obj.Upper)
            {
                Keys.UpperKeys(Row0, true);
                Keys.UpperKeys(Row1, true);
                Keys.UpperKeys(Row2, true);
                Keys.UpperKeys(Row3, true);
                Keys.UpperKeys(Row4, true);
            }
            else if(obj.Name == "SHIFT" && obj.Upper)
            {
                Keys.UpperKeys(Row0, false);
                Keys.UpperKeys(Row1, false);
                Keys.UpperKeys(Row2, false);
                Keys.UpperKeys(Row3, false);
                Keys.UpperKeys(Row4, false);
            }

            KeyPressed?.Invoke(obj);
            Text += obj.Name;
        }
    }
}
