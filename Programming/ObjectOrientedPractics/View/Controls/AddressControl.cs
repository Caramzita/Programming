using System;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View.Controls
{
    public partial class AddressControl : UserControl
    {
        /// <summary>
        /// Хранит данные адресса класса <see cref="Address"/>.
        /// </summary>
        private Address _address;

        /// <summary>
        /// Возвращает и задает адресс класса <see cref="Address"/>.
        /// </summary>
        public Address Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
            }
        }

        /// <summary>
        /// Создает экземпляр <see cref="AddressControl"/>.
        /// </summary>
        public AddressControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Очищает все <see cref="TextBox"/> адресса.
        /// </summary>
        public void ClearTextBox()
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
        /// Обновляет данные об адрессе, иначе очищает поля.
        /// </summary>
        public void UpdateTextBox()
        {
            try
            {
                IndexTextBox.Text = Address.Index.ToString();
                CountryTextBox.Text = Address.Country;
                CityTextBox.Text = Address.City;
                StreetTextBox.Text = Address.Street;
                BuildingTextBox.Text = Address.Building;
                ApartmentTextBox.Text = Address.Apartment;
            }
            catch
            {
                ClearTextBox();
            }
        }

        private void IndexTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Address.Index = Int32.Parse(IndexTextBox.Text);
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
