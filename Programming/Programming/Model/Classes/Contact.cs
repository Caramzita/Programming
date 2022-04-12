using System;
using System.Windows.Forms;

namespace Programming.Model.Classes
{
    public class Contact
    {
        private string _phoneNumber;
        private string _surname;
        private string _name;

        public Contact()
        {
        }

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

        public string PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                Validator.AssertValueInRange(value.Length, 11, 11, "Длина номера");
                if (long.TryParse(value, out long number) == false)
                {
                    throw new ArgumentException(
                        "Номер содержит только цифры");
                }
                _phoneNumber = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                AssertStringContainsOnlyLetters(Name, "Имя");   
                _name = value;
            }
        }

        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                AssertStringContainsOnlyLetters(Surname, "Фамилия");
                _surname = value;
            }
        }

        public string Email { get; set; }

        private void AssertStringContainsOnlyLetters(string value, string nameField)
        {
            for (int i = 0; i < value.Length; i++)
            {
                if (!char.IsLetter(value[i]))
                {
                    throw new ArgumentException($"{nameField} может содержать только английские буквы");
                }
            }
        }
    }
}
