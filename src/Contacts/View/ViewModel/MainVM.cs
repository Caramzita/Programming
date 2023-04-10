using System.ComponentModel;
using System.Runtime.CompilerServices;
using View.Model;
using View.Model.Services;
using System.Collections.ObjectModel;
using System;

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

        private ObservableCollection<Contact> _contacts = new ObservableCollection<Contact>();

        /// <summary>
        /// Хранит команду для сохранения данных.
        /// </summary>
        private RelayCommand _addCommand;

        /// <summary>
        /// Хранит команду для загрузки данных из файлов.
        /// </summary>
        private RelayCommand _removeCommand;

        private RelayCommand _editCommand;

        private RelayCommand _applyCommand;

        /// <summary>
        /// Хранит событие на изменение контакта. Зажигается при изменении свойства контакта.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Команда на выполнение сохранения данных.
        /// </summary>
        public RelayCommand AddCommand
        {
            get
            {
                return _addCommand ??
                  (_addCommand = new RelayCommand(obj =>
                  {
                      AddContact();
                  }));
            }
        }

        public RelayCommand ApplyCommand
        {
            get
            {
                return _addCommand ??
                  (_applyCommand = new RelayCommand(obj =>
                  {
                      ApplyContact();
                  }));
            }
        }

        /// <summary>
        /// Команда на выполнение загрузки данных из файла.
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

        public ObservableCollection<Contact> Contacts
        {
            get
            {
                return _contacts;
            }
        }

        private void AddContact()
        {
            CurrentContact = new Contact();
        }

        private void ApplyContact()
        {
            _contacts.Add(CurrentContact);
        }

        private void RemoveContact()
        {
            if(_contacts.Count > 1)
            {
                int index = _contacts.IndexOf(_currentContact);
                _contacts.RemoveAt(index);
                CurrentContact = _contacts[index];
            }

            if(_contacts.Count == 1)
            {
                _contacts.Remove(CurrentContact);
                CurrentContact = null;
            }
        }
        
        public void EditContact(Contact contact)
        {
            if (contact == null)
            {
                return;
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
