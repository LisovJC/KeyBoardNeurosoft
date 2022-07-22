using KeyBoard.Interfaces;
using KeyBoard.Models;
using System.Collections.Generic;

namespace KeyBoard.Services.Factories
{
    public class RusKeyFactory : IKeysFactory
    {
        public IEnumerable<Keys> FillingZeroRow()
        {
            List<Keys> keysRow0 = new List<Keys>
            {
                new Keys() { Name = "1" },
                new Keys() { Name = "2" },
                new Keys() { Name = "3" },
                new Keys() { Name = "4" },
                new Keys() { Name = "5" },
                new Keys() { Name = "6" },
                new Keys() { Name = "7" },
                new Keys() { Name = "8" },
                new Keys() { Name = "9" },
                new Keys() { Name = "0" }               
            };

            return keysRow0;
        }

        public IEnumerable<Keys> FillingFirstRow()
        {
            List<Keys> keysRow1 = new List<Keys>
            {
                new Keys() { Name = "Й" },
                new Keys() { Name = "Ц" },
                new Keys() { Name = "У" },
                new Keys() { Name = "К" },
                new Keys() { Name = "Е" },
                new Keys() { Name = "Н" },
                new Keys() { Name = "Г" },
                new Keys() { Name = "Ш" },
                new Keys() { Name = "Щ" },
                new Keys() { Name = "З" },
                new Keys() { Name = "Х" },
                new Keys() { Name = "Ъ" }
            };

            return keysRow1;
        }

        public IEnumerable<Keys> FillingSecondRow()
        {
            List<Keys> keysRow2 = new List<Keys>
            {
                new Keys() { Name = "Ф" },
                new Keys() { Name = "Ы" },
                new Keys() { Name = "В" },
                new Keys() { Name = "А" },
                new Keys() { Name = "П" },
                new Keys() { Name = "Р" },
                new Keys() { Name = "О" },
                new Keys() { Name = "Л" },
                new Keys() { Name = "Д" },
                new Keys() { Name = "Ж" },
                new Keys() { Name = "Э" }
            };

            return keysRow2;
        }

        public IEnumerable<Keys> FillingThridRow()
        {
            List<Keys> keysRow3 = new List<Keys>
            {
                new Keys() { Name = "SHIFT" },
                new Keys() { Name = "Я" },
                new Keys() { Name = "Ч" },
                new Keys() { Name = "С" },
                new Keys() { Name = "М" },
                new Keys() { Name = "И" },
                new Keys() { Name = "Т" },
                new Keys() { Name = "Ь" },
                new Keys() { Name = "Б" },
                new Keys() { Name = "Ю" }
            };

            return keysRow3;
        }
        }
    }

