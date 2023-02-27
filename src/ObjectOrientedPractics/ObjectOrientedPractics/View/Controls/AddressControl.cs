using System;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View.Controls
{
    /// <summary>
    /// Хранит данные о адресе доставки покупателя.
    /// </summary>
    public partial class AddressControl : UserControl
    {
        /// <summary>
        /// Возвращает и задает адрес класса <see cref="Address"/>.
        /// </summary>
        public Address Address { get; set; }

        /// <summary>
        /// Создает экземпляр <see cref="AddressControl"/>.
        /// </summary>
        public AddressControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Очищает все <see cref="TextBox"/> адреса.
        /// </summary>
        public void ClearAllTextBox()
        {
            IndexTextBox.Clear();
            IndexTextBox.BackColor = AppColors.CorrectColor;
            CountryTextBox.Clear();
            CityTextBox.Clear();
            StreetTextBox.Clear();
            BuildingTextBox.Clear();
            ApartmentTextBox.Clear();
        }

        /// <summary>
        /// Делает все поля доступными только для чтения.
        /// </summary>
        public void AddressIsReadOnly(bool flag)
        {
            IndexTextBox.ReadOnly = flag;
            CountryTextBox.ReadOnly = flag;
            CityTextBox.ReadOnly = flag;
            StreetTextBox.ReadOnly = flag;
            BuildingTextBox.ReadOnly = flag;
            ApartmentTextBox.ReadOnly = flag;
        }

        /// <summary>
        /// Обновляет данные об адресе, иначе очищает поля.
        /// </summary>
        public void UpdateTextBox()
        {
            try
            {
                IndexTextBox.Text = Address.PostalCode.ToString();
                CountryTextBox.Text = Address.Country;
                CityTextBox.Text = Address.City;
                StreetTextBox.Text = Address.Street;
                BuildingTextBox.Text = Address.Building;
                ApartmentTextBox.Text = Address.Apartment;
            }
            catch (NullReferenceException)
            {
                ClearAllTextBox();
            }
        }

        private void IndexTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Address.PostalCode = Int32.Parse(IndexTextBox.Text);
                ToolTip.SetToolTip(IndexTextBox, "");
                IndexTextBox.BackColor = AppColors.CorrectColor;
            }
            catch (Exception exception)
            {
                IndexTextBox.BackColor = AppColors.ErrorColor;
                ToolTip.SetToolTip(IndexTextBox, exception.Message);
                return;
            }
        }

        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Address.Country = CountryTextBox.Text;
                ToolTip.SetToolTip(CountryTextBox, "");
                CountryTextBox.BackColor = AppColors.CorrectColor;
            }
            catch (Exception exception)
            {
                CountryTextBox.BackColor = AppColors.ErrorColor;
                ToolTip.SetToolTip(CountryTextBox, exception.Message);
                return;
            }
        }

        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Address.City = CityTextBox.Text;
                ToolTip.SetToolTip(CityTextBox, "");
                CityTextBox.BackColor = AppColors.CorrectColor;
            }
            catch (Exception exception)
            {
                CityTextBox.BackColor = AppColors.ErrorColor;
                ToolTip.SetToolTip(CityTextBox, exception.Message);
                return;
            }
        }

        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Address.Street = StreetTextBox.Text;
                ToolTip.SetToolTip(StreetTextBox, "");
                StreetTextBox.BackColor = AppColors.CorrectColor;
            }
            catch (Exception exception)
            {
                StreetTextBox.BackColor = AppColors.ErrorColor;
                ToolTip.SetToolTip(StreetTextBox, exception.Message);
                return;
            }
        }

        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Address.Building = BuildingTextBox.Text;
                ToolTip.SetToolTip(BuildingTextBox, "");
                BuildingTextBox.BackColor = AppColors.CorrectColor;
            }
            catch (Exception exception)
            {
                BuildingTextBox.BackColor = AppColors.ErrorColor;
                ToolTip.SetToolTip(BuildingTextBox, exception.Message);
                return;
            }
        }

        private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Address.Apartment = ApartmentTextBox.Text;
                ToolTip.SetToolTip(ApartmentTextBox, "");
                ApartmentTextBox.BackColor = AppColors.CorrectColor;
            }
            catch (Exception exception)
            {
                ApartmentTextBox.BackColor = AppColors.ErrorColor;
                ToolTip.SetToolTip(ApartmentTextBox, exception.Message);
                return;
            }
        }
    }
}
