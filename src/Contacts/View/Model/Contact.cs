using System.ComponentModel;
using System.Runtime.CompilerServices;
using System;

namespace View.Model
{
    /// <summary>
    /// Хранит данные о контакте.
    /// </summary>
    public class Contact : INotifyPropertyChanged, ICloneable
    {
        /// <summary>
        /// Хранит полное имя контакта.
        /// </summary>
        private string _name;

        /// <summary>
        /// Хранит номер телефона контакта.
        /// </summary>
        private string _phoneNumber;

        /// <summary>
        /// Хранит электронный адрес контакта.
        /// </summary>
        private string _email;

        /// <summary>
        /// Хранит событие на изменение контакта. Зажигается при изменении свойства контакта.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Возвращает и задает имя контакта.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value != _name)
                {
                    _name = value;
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
                return _phoneNumber;
            }
            set
            {
                if (value != _phoneNumber)
                {
                    _phoneNumber = value;
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
                return _email;
            }
            set
            {
                if (value != _email)
                {
                    _email = value;
                    OnPropertyChanged(nameof(Email));
                }
            }
        }

        /// <summary>
        /// Создает клон текущего контакта.
        /// </summary>
        /// <returns>Клон контакта.</returns>
        public object Clone()
        {
            Contact contact = new Contact() 
            { 
                Name = this.Name,
                PhoneNumber = this.PhoneNumber,
                Email = this.Email
            };

            return contact;
        }

        /// <summary>
        /// Зажигает событие при изменении свойства контакта.
        /// </summary>
        /// <param name="prop">Имя свойства.</param>
        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
