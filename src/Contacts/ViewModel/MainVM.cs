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
        /// Возвращает и задает значение видимости.
        /// </summary>
        [ObservableProperty]
        private bool isEditMode;

        /// <summary>
        /// Возвращает и задает текущий контакт.
        /// </summary>
        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(RemoveContactCommand))]
        [NotifyCanExecuteChangedFor(nameof(EditContactCommand))]
        private Contact? currentContact;

        private bool CheckNullCurrentContact()
        {
            if (CurrentContact != null)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Возвращает и задает список контактов.
        /// </summary>
        [ObservableProperty]
        private ObservableCollection<Contact> contacts;

        [RelayCommand]
        private void AddContact()
        {
            _contactClone = null;
            CurrentContact = null;
            CurrentContact = new Contact();
            IsEditMode = true;
        }

        /// <summary>
        /// Применяет изменения контакта в текущий контакт.
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
        /// Удаляет выбранный контакт из списка контактов.
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
        /// Изменяет текущий контакт.
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
