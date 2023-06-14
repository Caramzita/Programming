using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Model;
using Model.Services;

namespace ViewModel
{
    /// <summary>
    /// ViewModel главного окна.
    /// </summary>
    public partial class MainVM : ObservableObject
    {
        /// <summary>
        /// Хранит клон текущего контакта.
        /// </summary>
        private Contact _contactClone;

        /// <summary>
        /// Хранит состояние текущего контакта.
        /// </summary>
        private Contact _initialContact;

        /// <summary>
        /// Хранит текущий контакт.
        /// </summary>
        private Contact _currentContact;

        /// <summary>
        /// Возвращает и задает значение видимости.
        /// </summary>
        [ObservableProperty]
        public bool isEditMode;

        /// <summary>
        /// Возвращает и задает текущий контакт.
        /// </summary>
        public Contact CurrentContact
        {
            get => _currentContact;
            set
            {
                if (SetProperty(ref _currentContact, value))
                {
                    IsEditMode = false;
                    RemoveContactCommand.NotifyCanExecuteChanged();
                    EditContactCommand.NotifyCanExecuteChanged();
                    ApplyContactCommand.NotifyCanExecuteChanged();
                }
            }
        }

        /// <summary>
        /// Возвращает и задает список контактов.
        /// </summary>
        [ObservableProperty]
        public ObservableCollection<Contact> contacts;

        /// <summary>
        /// Проверяет текущий контакт на null.
        /// </summary>
        /// <returns>Возвращает true, если текущий контакт не равен null, иначе false.</returns>
        private bool CheckNullCurrentContact()
        {
            return CurrentContact is not null;
        }

        /// <summary>
        /// Команда на добавление контакта.
        /// </summary>
        [RelayCommand]
        private void AddContact()
        {
            _contactClone = null;
            CurrentContact = null;
            CurrentContact = new Contact();
            IsEditMode = true;
        }

        /// <summary>
        /// Команда на применение внесенных изменений в текущий контакт.
        /// </summary>
        [RelayCommand]
        private void ApplyContact()
        {
            IsEditMode = false;

            if (_contactClone != null)
            {
                int index = Contacts.IndexOf(_initialContact);

                Contacts[index] = CurrentContact;
                _contactClone = null;
                CurrentContact = Contacts[index];

                return;
            }

            if (!Contacts.Contains(CurrentContact))
            {
                Contacts.Add(CurrentContact);
                return;
            }
        }

        /// <summary>
        /// Команда на удаление выбранного контакта из списка контактов.
        /// </summary>
        [RelayCommand(CanExecute = nameof(CheckNullCurrentContact))]
        private void RemoveContact()
        {
            if (Contacts.Count > 1)
            {
                int index = Contacts.IndexOf(CurrentContact);

                if (index == 0)
                {
                    CurrentContact = Contacts[index + 1];
                }
                else
                {
                    CurrentContact = Contacts[index - 1];
                }

                Contacts.RemoveAt(index);
            }
            else
            {
                Contacts.Remove(CurrentContact);
            }
        }

        /// <summary>
        /// Команда на изменение текущего контакта.
        /// </summary>
        [RelayCommand(CanExecute = nameof(CheckNullCurrentContact))]
        private void EditContact()
        {
            _contactClone = (Contact)CurrentContact.Clone();
            _initialContact = CurrentContact;
            CurrentContact = _contactClone;

            if (CurrentContact != null && Contacts.Count > 0)
            {
                IsEditMode = true;
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
    }
}
