using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace Model
{
    /// <summary>
    /// Хранит данные о контакте.
    /// </summary>
    public class Contact : INotifyPropertyChanged, ICloneable, IDataErrorInfo
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

        public string this[string columnName]
        {
            get
            {
                string errorMessage = String.Empty;
                switch (columnName)
                {
                    case nameof(Name):
                        if ((Name.Length <= 0) || (Name.Length > 100))
                        {
                            errorMessage = "Имя должно быть больше 0 и меньше 100 символов";
                        }

                        break;
                    case nameof(PhoneNumber):
                        if (!Regex.Match(PhoneNumber, @"^\+?[0-9]\s?\(?\d{3}\)?\s?\d{3}[\s-]?\d{2}[\s-]?\d{2}$").Success)
                        {
                            errorMessage = "Номер телефона может содержать только цифры и символы '+()-'." +
                                "Например: +7 (800) 555-35-35";
                        }

                        break;
                    case nameof(Email):
                        if ((Email.Length < 0 || Email.Length > 100) || !Regex.Match(Email, @"\w+[@]\w*[.]\w+").Success)
                        {
                            errorMessage = "Почта должна быть больше 0 и меньше 100 символов, а также" +
                                "должна содержать @";
                        }
                        break;
                }
                return errorMessage;
            }
        }

        public string Error
        {
            get { return null; }
        }

        public Contact()
        {
            Name = String.Empty;
            PhoneNumber = String.Empty;
            Email = String.Empty;
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
