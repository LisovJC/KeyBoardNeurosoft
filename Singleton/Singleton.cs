using KeyBoard.Services.Factories;
using KeyBoard.ViewModels;

namespace KeyBoard.Singleton
{
    public class Singleton
    {
        private static Singleton instance;

        public static Singleton getInstance()
        {
            if (instance == null)
                instance = new Singleton();
            return instance;
        }

        private Singleton()
        { }

        private MainViewModel _vm = new MainViewModel(new RusKeyFactory());

        public MainViewModel Vm
        {
            get => _vm;
            set { _vm = value; }
        }
    }
}
