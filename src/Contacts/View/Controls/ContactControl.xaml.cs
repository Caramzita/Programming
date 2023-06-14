using System.Windows;
using System.Windows.Controls;
using System.Text.RegularExpressions;
using System.Windows.Input;
using Model;
using System.ComponentModel;

namespace View.Controls
{
    /// <summary>
    /// Логика взаимодействия для ContactControl.xaml
    /// </summary>
    public partial class ContactControl : UserControl
    {
        /// <summary>
        /// Хранит свойство зависимости возможности редактирования.
        /// </summary>
        public static readonly DependencyProperty IsEditProperty =
            DependencyProperty.Register(nameof(IsEdit), typeof(bool), typeof(ContactControl));

        public static readonly DependencyProperty IsValidateProperty =
            DependencyProperty.Register(nameof(IsValidate), typeof(bool), typeof(ContactControl));

        /// <summary>
        /// Возвращает и задает возможность редактирования.
        /// </summary>
        public bool IsEdit
        {
            get => (bool)GetValue(IsEditProperty);
            set => SetValue(IsEditProperty, value);
        }

        public bool IsValidate
        {
            get => (bool)GetValue(IsValidateProperty);
            set => SetValue(IsValidateProperty, value);
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="ContactControl"/>
        /// </summary>
        public ContactControl()
        {
            InitializeComponent();
            //var indei = DataContext as INotifyDataErrorInfo;
            //if (indei != null)
            //{
            //    indei.ErrorsChanged += Indei_ErrorsChanged; 
            //}
        }

        //private void Indei_ErrorsChanged(object? sender, DataErrorsChangedEventArgs e)
        //{
        //    var indei = DataContext as INotifyDataErrorInfo;
        //    IsValidate = !indei.HasErrors;
        //}

        private void PhoneNumberTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = Regex.IsMatch(e.Text, "[^0-9+()-]+$");
        }

        private void PhoneNumberTextBox_Pasting(object sender, DataObjectPastingEventArgs e)
        {
            if (e.DataObject.GetDataPresent(typeof(string)))
            {
                string text = (string)e.DataObject.GetData(typeof(string));
                if (Regex.IsMatch(text, "[^0-9+()]+"))
                {
                    e.CancelCommand();
                }
            }
            else
            {
                e.CancelCommand();
            }
        }
    }
}
