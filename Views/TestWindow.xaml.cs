using System.Windows;

namespace KeyBoard
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = Singleton.Singleton.getInstance().Vm;
        }
    }
}
