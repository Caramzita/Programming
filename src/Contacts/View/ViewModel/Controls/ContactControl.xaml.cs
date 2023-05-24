using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using View.Model;

namespace View.ViewModel.Controls
{
    /// <summary>
    /// Логика взаимодействия для ContactControl.xaml
    /// </summary>
    public partial class ContactControl : UserControl
    {
        public static readonly DependencyProperty IsEditProperty = 
            DependencyProperty.Register(nameof(IsEdit), typeof(bool), typeof(ContactControl));

        public bool IsEdit
        {
            get => (bool)GetValue(IsEditProperty);
            set => SetValue(IsEditProperty, value);
        }

        public ContactControl()
        {
            InitializeComponent();
        }
    }
}
