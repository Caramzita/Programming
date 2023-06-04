using System.Windows;
using ViewModel;

namespace View
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainVM _vm;

        /// <summary>
        /// Создает экземпляр класса <see cref="MainWindow"/>.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            _vm = new MainVM();
            DataContext = _vm;

            this.Closing += MainWindow_Closing;
            this.Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _vm.Save();
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            _vm.Load();
        }
    }
}
