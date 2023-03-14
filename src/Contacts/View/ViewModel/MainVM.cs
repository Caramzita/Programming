using System.ComponentModel;
using System.Runtime.CompilerServices;
using View.Model;
using View.Model.Services;

namespace View.ViewModel
{
    /// <summary>
    /// ViewModel главного окна.
    /// </summary>
    internal class MainVM : INotifyPropertyChanged
    {
        /// <summary>
        /// Хранит текущий контакт.
        /// </summary>
        private Contact _currentContact = new Contact(); 

        /// <summary>
        /// Хранит команду для сохранения данных.
        /// </summary>
        private RelayCommand _saveCommand;

        /// <summary>
        /// Хранит команду для загрузки данных из файлов.
        /// </summary>
        private RelayCommand _loadCommand;

        /// <summary>
        /// Хранит событие на изменение контакта. Зажигается при изменении свойства контакта.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Команда на выполнение сохранения данных.
        /// </summary>
        public RelayCommand SaveCommand
        {
            get
            {
                return _saveCommand ??
                  (_saveCommand = new RelayCommand(obj =>
                  {
                      ContactSerializer.SaveData(CurrentContact);
                  }));
            }
        }      

        /// <summary>
        /// Команда на выполнение загрузки данных из файла.
        /// </summary>
        public RelayCommand LoadCommand
        {
            get
            {
                return _loadCommand ??
                  (_loadCommand = new RelayCommand(obj =>
                  {
                      CurrentContact = ContactSerializer.LoadDataFromFile();
                  }));
            }
        }

        /// <summary>
        /// Возвращает и задает имя контакта.
        /// </summary>
        public string Name
        {
            get
            {
                return _currentContact.Name;
            }
            set
            {
                if (value != _currentContact.Name)
                {
                    _currentContact.Name = value;
                    OnPropertyChanged(nameof(Name));
                }               
            }
        }

        /// <summary>
        /// Возвращает и задает телефон контакта.
        /// </summary>
        public string PhoneNumber
        {
            get
            {
                return _currentContact.PhoneNumber;
            }
            set
            {
                if (value != _currentContact.PhoneNumber)
                {
                    _currentContact.PhoneNumber = value;
                    OnPropertyChanged(nameof(PhoneNumber));
                }
            }
        }

        /// <summary>
        /// Возвращает и задает электронный адрес контакта.
        /// </summary>
        public string Email
        {
            get
            {
                return _currentContact.Email;
            }
            set
            {
                if (value != _currentContact.Email)
                {
                    _currentContact.Email = value;
                    OnPropertyChanged(nameof(Email));
                }
            }
        } 
        
        /// <summary>
        /// Возвращает и задает текущий контакт.
        /// </summary>
        public Contact CurrentContact
        {
            get
            {
                return _currentContact;
            }
            set
            {
                if( value != _currentContact)
                {
                    _currentContact = value;
                    OnPropertyChanged(nameof(CurrentContact));
                }
            }
        }

        /// <summary>
        /// Зажигает событие при изменении свойства контакта.
        /// </summary>
        /// <param name="prop">Имя свойства.</param>
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }   
}
