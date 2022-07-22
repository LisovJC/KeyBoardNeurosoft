using KeyBoard.Models;
using System.Collections.Generic;

namespace KeyBoard.Interfaces
{
    public interface IKeysFactory
    {
        IEnumerable<Keys> FillingZeroRow();
        IEnumerable<Keys> FillingFirstRow();
        IEnumerable<Keys> FillingSecondRow();
        IEnumerable<Keys> FillingThridRow();
    }
}
