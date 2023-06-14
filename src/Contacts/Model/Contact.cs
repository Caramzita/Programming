using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace Model
{
    /// <summary>
    /// Хранит данные о контакте.
    /// </summary>
    public class Contact : INotifyPropertyChanged, ICloneable, INotifyDataErrorInfo
    {
        /// <summary>
        /// Хранит словарь ошибок контакта.
        /// </summary>
        private readonly Dictionary<string, List<string>> _propertyErrors = 
            new Dictionary<string,List<string>>();

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
        /// Хранит событие на ошибки контакта. Зажигается при возникновении ошибки валидации контакта.
        /// </summary>
        public event EventHandler<DataErrorsChangedEventArgs>? ErrorsChanged;

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

                    ClearError(nameof(Name));
                    if ((Name.Length <= 0) || (Name.Length > 100))
                    {
                        AddError(nameof(Name), "Имя должно быть больше 0 и меньше 100 символов");
                    }

                    OnPropertyChanged(nameof(HasErrors));
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
                    ClearError(nameof(PhoneNumber));

                    if (!Regex.Match(_phoneNumber,
                        @"^\+?[0-9]\s?\(?\d{3}\)?\s?\d{3}[\s-]?\d{2}[\s-]?\d{2}$").Success)
                    {
                        AddError(nameof(PhoneNumber), "Номер телефона может содержать только " +
                            "цифры и символы '+()-'. Например: +7 (800) 555-35-35");
                    }

                    OnPropertyChanged(nameof(HasErrors));
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

                    ClearError(nameof(Email));

                    if ((Email.Length < 0 || Email.Length > 100) || 
                        !Regex.Match(Email, @"\w+[@]\w*[.]\w+").Success)
                    {
                        AddError(nameof(Email), "Почта должна быть больше 0 и меньше 100 символов, " +
                            "а также должна содержать @");
                    }

                    OnPropertyChanged(nameof(HasErrors));
                    OnPropertyChanged(nameof(Email));
                }
            }
        }

        /// <summary>
        /// Возвращает есть ли ошибки в контакте.
        /// </summary>
        public bool HasErrors => _propertyErrors.Any();

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

        /// <inheritdoc/>
        public IEnumerable GetErrors(string? propertyName)
        {
            return _propertyErrors.GetValueOrDefault(propertyName, null);
        }

        /// <summary>
        /// Добавляет ошибки с словарь.
        /// </summary>
        /// <param name="propertyName">Название свойства, где произошла ошибка.</param>
        /// <param name="errorMessage">Сообщение ошибки.</param>
        public void AddError(string propertyName, string errorMessage)
        {
            if (!_propertyErrors.ContainsKey(propertyName))
            {
                _propertyErrors.Add(propertyName, new List<string>());
            }

            _propertyErrors[propertyName].Add(errorMessage);
            OnErrorsChanged(propertyName);
        }

        /// <summary>
        /// Удаляет ошибку из словаря.
        /// </summary>
        /// <param name="propertyName">Название свойства, где произошла ошибка.</param>
        public void ClearError(string propertyName)
        {
            if (_propertyErrors.Remove(propertyName))
            {
                OnPropertyChanged(propertyName);
            }
        }

        /// <summary>
        /// Зажигается при возникновении ошибки.
        /// </summary>
        /// <param name="propertyName">Название свойства, где произошла ошибка.</param>
        private void OnErrorsChanged(string propertyName)
        {
            ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(propertyName));
            OnPropertyChanged(nameof(HasErrors));
        }
    }
}
