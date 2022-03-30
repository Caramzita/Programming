using System;

namespace Programming.Model.Classes
{
    public class Contact
    {
        private string _phoneNumber;

        public Contact()
        {
        }

        public Contact(string name,
                       string phoneNumber,
                       string email)
        {
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
                if (value.Length != 11)
                {
                    throw new ArgumentException(
                        "Длина не соответствует стандарту номера");
                }
                if (long.TryParse(value, out long number) == false)
                {
                    throw new ArgumentException(
                        "Номер содержит только цифры");
                }
                _phoneNumber = value;
            }
        }

        public string Name { get; set; }

        public string Email { get; set; }
    }
}
