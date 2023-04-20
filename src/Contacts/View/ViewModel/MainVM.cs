using System.ComponentModel;
using System.Runtime.CompilerServices;
using View.Model;
using View.Model.Services;
using System.Collections.ObjectModel;

namespace View.ViewModel
{
    /// <summary>
    /// ViewModel главного окна.
    /// </summary>
    public class MainVM : INotifyPropertyChanged
    {
        /// <summary>
        /// Хранит текущий контакт.
        /// </summary>
        private Contact _currentContact; 

        /// <summary>
        /// Хранит список контактов.
        /// </summary>
        private ObservableCollection<Contact> _contacts = new ObservableCollection<Contact>();

        /// <summary>
        /// Хранит команду для добавления контакта.
        /// </summary>
        private RelayCommand _addCommand;

        /// <summary>
        /// Хранит команду для удаления контакта.
        /// </summary>
        private RelayCommand _removeCommand;

        /// <summary>
        /// Хранит команду для изменения контакта.
        /// </summary>
        private RelayCommand _editCommand;

        /// <summary>
        /// Хранит команду для применения изменений контакта.
        /// </summary>
        private RelayCommand _applyCommand;

        /// <summary>
        /// Хранит значение видимости.
        /// </summary>
        private bool _isVisibility = false;

        /// <summary>
        /// Хранит клон текущего контакта.
        /// </summary>
        private Contact _contactClone;

        /// <summary>
        /// Хранит исходный текущий контакт.
        /// </summary>
        private Contact _initialContact;

        /// <summary>
        /// Хранит событие на изменение контакта. Зажигается при изменении свойства контакта.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Возвращает и задает значение доступности на чтение.
        /// </summary>
        public bool IsReadOnly
        {
            get
            {
                return !_isVisibility;
            }
            private set
            {
                _isVisibility = !value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Возвращает и задает значение видимости.
        /// </summary>
        public bool IsVisibility
        {
            get
            {
                return _isVisibility;
            }
            private set
            {
                _isVisibility = value;
                OnPropertyChanged();
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
                if (value != _currentContact)
                {
                    _currentContact = value;

                    IsVisibility = false;
                    IsReadOnly = true;           

                    OnPropertyChanged(nameof(CurrentContact));
                }
            }
        }

        /// <summary>
        /// Возвращает и задает список контактов.
        /// </summary>
        public ObservableCollection<Contact> Contacts
        {
            get
            {
                return _contacts;
            }
            private set
            {
                if (value != _contacts)
                {
                    _contacts = value;
                    OnPropertyChanged(nameof(Contacts));
                }
            }
        }

        /// <summary>
        /// Команда на добавление контакта.
        /// </summary>
        public RelayCommand AddCommand
        {
            get
            {
                return _addCommand ??
                  (_addCommand = new RelayCommand(obj =>
                  {
                      _contactClone = null;
                      CurrentContact = null;
                      CurrentContact = new Contact();
                      IsReadOnly = false;
                      IsVisibility = true;
                  }));
            }
        }

        /// <summary>
        /// Команда на применение изменений контакта.
        /// </summary>
        public RelayCommand ApplyCommand
        {
            get
            {
                return _applyCommand ??
                  (_applyCommand = new RelayCommand(obj =>
                  {
                      ApplyContact();
                  }));
            }
        }

        /// <summary>
        /// Команда на удаление контакта.
        /// </summary>
        public RelayCommand RemoveCommand
        {
            get
            {
                return _removeCommand ??
                  (_removeCommand = new RelayCommand(obj =>
                  {
                      RemoveContact();
                  }));
            }
        }

        /// <summary>
        /// Команда на изменение контакта.
        /// </summary>
        public RelayCommand EditCommand
        {
            get
            {
                return _editCommand ??
                  (_editCommand = new RelayCommand(obj =>
                  {
                     EditContact();                    
                  }));
            }
        }

        /// <summary>
        /// Применяет изменения контакта в текущий контакт.
        /// </summary>
        private void ApplyContact()
        {
            IsVisibility = false;
            IsReadOnly = true;

            if (_contactClone != null)
            {
                _initialContact.Name = CurrentContact.Name;
                _initialContact.PhoneNumber = CurrentContact.PhoneNumber;
                _initialContact.Email = CurrentContact.Email;

                _contactClone = null;

                return;
            }

            if (!Contacts.Contains(CurrentContact))
            {
                _contacts.Add(CurrentContact);
                return;
            }
        }

        /// <summary>
        /// Удаляет выбранный контакт из списка контактов.
        /// </summary>
        private void RemoveContact()
        {
            if (CurrentContact == null)
            {
                return;
            }

            if (_contacts.Count > 1 && CurrentContact != null)
            {
                int index = _contacts.IndexOf(_currentContact);

                if (index == 0)
                {
                    CurrentContact = _contacts[index + 1];
                }
                else
                {
                    CurrentContact = _contacts[index - 1];
                }

                _contacts.RemoveAt(index);
            }
            else
            {
                _contacts.Remove(CurrentContact);
                CurrentContact = null;
            }
        }
        
        /// <summary>
        /// Изменяет текущий контакт.
        /// </summary>
        public void EditContact()
        {
            if (CurrentContact == null)
            {
                return;
            }

            _contactClone = (Contact)CurrentContact.Clone();
            _initialContact = CurrentContact;
            CurrentContact = _contactClone;

            if (_currentContact != null && _contacts.Count > 0)
            {
                IsReadOnly = false;
                IsVisibility = true;
            }      
        }

        /// <summary>
        /// Сохраняет данные списка контактов.
        /// </summary>
        public void Save()
        {
            ContactSerializer.SaveData(Contacts);
        }

        /// <summary>
        /// Загружает данные списка контактов.
        /// </summary>
        public void Load()
        {
            Contacts = ContactSerializer.LoadDataFromFile();
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
