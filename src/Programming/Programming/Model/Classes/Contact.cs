using System;
using System.Windows.Forms;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о человеке и его контактах.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Хранит номер телефона.
        /// </summary>
        private string _phoneNumber;

        /// <summary>
        /// Хранит фамилию человека.
        /// </summary>
        private string _surname;

        /// <summary>
        /// Хранит имя человека.
        /// </summary>
        private string _name;

        /// <summary>
        /// Создает пустой экземпляр класса <see cref="Contact"/>.
        /// </summary>
        public Contact()
        {
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Contact"/>.
        /// </summary>
        /// <param name="name">Имя. Должно состоять только из букв.</param>
        /// <param name="surname">Фамилия. Должна состоять только из букв.</param>
        /// <param name="phoneNumber">Номер телефона. Должен состоять только из цифр.</param>
        /// <param name="email">Почта. В конце должна иметь @домен почтового ящика.</param>
        public Contact(string name,
                       string surname,
                       string phoneNumber,
                       string email)
        {
            Surname = surname;
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        /// <summary>
        /// Возвращает и задает номер телефона. Должен состоять только из цифр.
        /// </summary>
        public string PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                Validator.AssertValueInRange(value.Length, 11, 11, nameof(PhoneNumber));
                if (long.TryParse(value, out long number) == false)
                {
                    throw new ArgumentException(
                        "The number contains only numbers");
                }
                _phoneNumber = value;
            }
        }

        /// <summary>
        /// Возвращает и задает имя человека. Должно состоять только из букв.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                AssertStringContainsOnlyLetters(Name, nameof(Name));   
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задает фамилию человека. Должна состоять только из букв.
        /// </summary>
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                AssertStringContainsOnlyLetters(Surname, nameof(Surname));
                _surname = value;
            }
        }

        /// <summary>
        /// Возвращает и задает почту человка. В конце должна иметь @домен почтового ящика.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Проверяет, что строка состоит только из букв.
        /// </summary>
        /// <param name="value">Проверяемая строка.</param>
        /// <param name="fieldName">Название поля.</param>
        /// <returns>Возвращает true, если строка состоит из букв и false, если есть хотя бы одна не буква.</returns>
        private bool AssertStringContainsOnlyLetters(string value, string fieldName)
        {
            for (int i = 0; i < value.Length; i++)
            {
                if (!char.IsLetter(value[i]))
                {
                    return false;
                    throw new ArgumentException($"{fieldName} can only contain English letters");
                    
                }
            }
            return true;
        }
    }
}
