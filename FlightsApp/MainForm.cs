using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using FlightsApp.Model;


namespace FlightsApp
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Хранит список всех перелетов.
        /// </summary>
        private List<Flight> _flights = ProjectSerializer.LoadFromFile();

        /// <summary>
        /// Хранит данные о выбранном перелете.
        /// </summary>
        private Flight _currentFlight;

        /// <summary>
        /// Создает экземпляр класса <see cref="MainForm"/>.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Создает строку со значениями перелета.
        /// </summary>
        /// <param name="flight">Выбранный перелет.</param>
        /// <returns>Возвращает строку со значения перелета.</returns>
        private string GetInfoFlight(Flight flight)
        {
            return $"{flight.DepartureTime}: {flight.Departure} - " +
                    $"{flight.Destination}";
        }

        /// <summary>
        /// Сортирует список перелетов по дате вылета.
        /// </summary>
        private void SortFlights()
        {
            _flights = _flights.OrderBy(flight => flight.DepartureTime).ToList();
        }

        /// <summary>
        /// Обновляет данные перелтов в <see cref="FlightsListBox"/> при их изменении.
        /// </summary>
        /// <param name="flights">Выбранный перелет.</param>
        private void UpdateInfo(List<Flight> flights)
        {
            for(int i = 0; i < _flights.Count; i++)
            {
                FlightsListBox.Items[i] = GetInfoFlight(flights[i]);
            }
        }

        /// <summary>
        /// Очищает TextBox при отсутсвии выбранного перелета.
        /// </summary>
        private void ClearInfo()
        {
            DepartureTextBox.Clear();
            DestinationTextBox.Clear();
            DepartureTimePicker.Text = null;
            DurationTextBox.Clear();
            DurationTextBox.BackColor = AppColors.CorrectColor;
            FlightTypeComboBox.Text = null;
        }

        private void FlightsApp_Load(object sender, EventArgs e)
        {
            FlightTypeComboBox.Items.AddRange(Enum.GetNames(typeof(FlightType)));
            if (_flights == null || _flights.Count == 0)
            {
                _flights = new List<Flight>();
                for (int i = 0; i < 11; i++)
                {
                    _flights.Add(FlightFactory.MakeFlights());
                }
                SortFlights();
            }
            foreach (var flight in _flights)
            {
                FlightsListBox.Items.Add(GetInfoFlight(flight));
            }
            FlightsListBox.SelectedIndex = 0;
            DepartureTimePicker.MinDate = DateTime.Now;
        }

        private void FlightsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(FlightsListBox.SelectedIndex != -1)
                {
                    var index = FlightsListBox.SelectedIndex;
                    _currentFlight = _flights[index];
                    DepartureTextBox.Text = _currentFlight.Departure;
                    DestinationTextBox.Text = _currentFlight.Destination;
                    DepartureTimePicker.Value = _currentFlight.DepartureTime;
                    DurationTextBox.Text = _currentFlight.Duration.ToString();
                    FlightTypeComboBox.SelectedItem = _currentFlight.FlightType;
                }
            }
            catch { }
        }

        private void DepartureTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentFlight.Departure = DepartureTextBox.Text;
                DepartureTextBox.BackColor = AppColors.CorrectColor;
                UpdateInfo(_flights);
            }
            catch (Exception exception)
            {
                ToolTip.SetToolTip(DepartureTextBox, exception.Message);
                DepartureTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
        }

        private void DestinationTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentFlight.Destination = DestinationTextBox.Text;
                DestinationTextBox.BackColor = AppColors.CorrectColor;
                UpdateInfo(_flights);
            }
            catch (Exception exception)
            {
                ToolTip.SetToolTip(DestinationTextBox, exception.Message);
                DestinationTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
        }

        private void DepartureTimePicker_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                _currentFlight.DepartureTime = DepartureTimePicker.Value;
                UpdateInfo(_flights);
            }
            catch (Exception exception)
            {
                ToolTip.SetToolTip(DepartureTimePicker, exception.Message);
                return;
            }
        }

        private void DurationTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentFlight.Duration = Convert.ToInt32(DurationTextBox.Text);
                DurationTextBox.BackColor = AppColors.CorrectColor;
                UpdateInfo(_flights);
            }
            catch(Exception exception)
            {
                ToolTip.SetToolTip(DurationTextBox, exception.Message);
                DurationTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
        }

        private void DepartureTimePicker_Leave(object sender, EventArgs e)
        {
            FlightsListBox.Items.Clear();
            SortFlights();
            foreach (var flight in _flights)
            {
                FlightsListBox.Items.Add(GetInfoFlight(flight));
            }
        }

        private void FlightTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _currentFlight.FlightType = (string)FlightTypeComboBox.SelectedItem;
            }
            catch { return; }
        }  

        private void AddPictureBox_Click(object sender, EventArgs e)
        {
            _flights.Add(FlightFactory.MakeFlights());
            var selectedFlight = _flights[_flights.Count - 1];
            FlightsListBox.Items.Clear();
            SortFlights();
            foreach (var flight in _flights)
            {
                FlightsListBox.Items.Add(GetInfoFlight(flight));
            }
            FlightsListBox.SelectedIndex = _flights.IndexOf(selectedFlight);
        }

        private void RemovePictureBox_Click(object sender, EventArgs e)
        {
            int selectedIndex = FlightsListBox.SelectedIndex;
            if (_flights.Count != 0 && selectedIndex >= 0)
            {
                _flights.RemoveAt(selectedIndex);
                FlightsListBox.Items.Remove(FlightsListBox.SelectedItem);
                FlightsListBox.SelectedIndex = selectedIndex - 1;
                if(FlightsListBox.SelectedIndex == -1)
                {
                    ClearInfo();
                }
            }
        }
        private void AddPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            AddPictureBox.BackgroundImage = ButtonImage.ActiveAddPicture;
        }

        private void AddPictureBox_MouseLeave(object sender, EventArgs e)
        {
            AddPictureBox.BackgroundImage = ButtonImage.AddPicture;
        }

        private void RemovePictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            RemovePictureBox.BackgroundImage = ButtonImage.ActiveRemovePicture;
        }

        private void RemovePictureBox_MouseLeave(object sender, EventArgs e)
        {
            RemovePictureBox.BackgroundImage = ButtonImage.RemovePicture;
        }

        private void FlightsApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            ProjectSerializer.SaveToFile(_flights);
        }
    }
}
