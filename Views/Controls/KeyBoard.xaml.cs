using System.Windows.Controls;

namespace KeyBoard.Views.Controls
{
    public partial class KeyBoard : UserControl
    {
        public KeyBoard()
        {
            InitializeComponent();
            DataContext = Singleton.Singleton.getInstance().Vm;
        }
    }
}
