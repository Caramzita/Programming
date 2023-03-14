
namespace View.Model
{
    /// <summary>
    /// Хранит данные о контакте.
    /// </summary>
    internal class Contact
    {
        /// <summary>
        /// Хранит полное имя контакта.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Хранит номер телефона контакта.
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Хранит электронный адрес контакта.
        /// </summary>
        public string Email { get; set; }
    }
}
