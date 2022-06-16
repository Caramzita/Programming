using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlightsApp.Model;

namespace FlightsApp
{
    public partial class FlightsApp : Form
    {
        private readonly Color ErrorColor = Color.LightPink;

        private readonly Color CorrectColor = Color.White;

        private string[] _flightType = { "Interior", "International" };

        private List<Flight> _flights = new List<Flight>();

        private Flight _currentFlight;

        private Random random = new Random();

        private Image _addPicture = Properties.Resources.AddButton;

        private Image _activeAddPicture = Properties.Resources.ActiveAddButton;

        private Image _removePicture = Properties.Resources.RemoveButton;

        private Image _activeRemovePicture = Properties.Resources.ActiveRemoveButton;

        public FlightsApp()
        {
            InitializeComponent();
            FlightTypeComboBox.Items.AddRange(_flightType);
            for(int i = 0; i < 11; i++)
            {
                _flights.Add(MakeFlights());  
            }
            SortFlights();
            foreach (var flight in _flights)
            {
                FlightsListBox.Items.Add(GetInfoFlight(flight));
            }
            FlightsListBox.SelectedIndex = 0;
            DepartureTimePicker.MinDate = DateTime.Now;
        }

        private Flight MakeFlights()
        {
            var now = DateTime.Now;
            DateTime randomDate = new DateTime(random.Next(now.Year, 2023),
                random.Next(now.Month, 13), random.Next(now.Day, 31), random.Next(now.Hour, 24),
                random.Next(now.Minute, 60), 0);
            _currentFlight = new Flight(City.Cities[random.Next(0, City.Cities.Length)],
                City.Cities[random.Next(0, City.Cities.Length)],
                randomDate, random.Next(1, 1000), _flightType[random.Next(0, 2)]);
            return _currentFlight;
        }

        private string GetInfoFlight(Flight flight)
        {
            return $"{flight.DepartureTime}: {flight.Departure} - " +
                    $"{flight.Destination}";
        }

        private void SortFlights()
        {
            _flights = _flights.OrderBy(flight => flight.DepartureTime).ToList();
        }

        private void UpdateInfo(List<Flight> flights)
        {
            for(int i = 0; i < _flights.Count; i++)
            {
                FlightsListBox.Items[i] = GetInfoFlight(flights[i]);
            }
        }

        private void ClearInfo()
        {
            DepartureTextBox.Clear();
            DestinationTextBox.Clear();
            DepartureTimePicker.Text = null;
            DurationTextBox.Clear();
            DurationTextBox.BackColor = CorrectColor;
            FlightTypeComboBox.Text = null;
        }

        private void FlightsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _currentFlight = _flights[FlightsListBox.SelectedIndex];
                DepartureTextBox.Text = _currentFlight.Departure;
                DestinationTextBox.Text = _currentFlight.Destination;
                DepartureTimePicker.Value = _currentFlight.DepartureTime;
                DurationTextBox.Text = _currentFlight.Duration.ToString();
                FlightTypeComboBox.SelectedItem = _currentFlight.FlightType; 
            }
            catch 
            {
                ClearInfo();
            }
        }

        private void DepartureTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentFlight.Departure = DepartureTextBox.Text;
                DepartureTextBox.BackColor = CorrectColor;
                //UpdateInfo(_flights);
            }
            catch (Exception exception)
            {
                ToolTip.SetToolTip(DepartureTextBox, exception.Message);
                DepartureTextBox.BackColor = ErrorColor;
                return;
            }
        }

        private void DestinationTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentFlight.Destination = DestinationTextBox.Text;
                DestinationTextBox.BackColor = CorrectColor;
                //UpdateInfo(_flights);
            }
            catch (Exception exception)
            {
                ToolTip.SetToolTip(DestinationTextBox, exception.Message);
                DestinationTextBox.BackColor = ErrorColor;
                return;
            }
        }

        private void DepartureTimePicker_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                _currentFlight.DepartureTime = DepartureTimePicker.Value;
                //UpdateInfo(_flights);
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
                DurationTextBox.BackColor = CorrectColor;
                //UpdateInfo(_flights);
            }
            catch(Exception exception)
            {
                ToolTip.SetToolTip(DurationTextBox, exception.Message);
                DurationTextBox.BackColor = ErrorColor;
                return;
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
        
        private void AddPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            AddPictureBox.BackgroundImage = _activeAddPicture;
        }

        private void AddPictureBox_MouseLeave(object sender, EventArgs e)
        {
            AddPictureBox.BackgroundImage = _addPicture;
        }

        private void RemovePictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            RemovePictureBox.BackgroundImage = _activeRemovePicture;
        }

        private void RemovePictureBox_MouseLeave(object sender, EventArgs e)
        {
            RemovePictureBox.BackgroundImage = _removePicture;
        }

        private void AddPictureBox_Click(object sender, EventArgs e)
        {
            _flights.Add(MakeFlights());
            FlightsListBox.Items.Add($"{_currentFlight.DepartureTime}: {_currentFlight.Departure} - " +
                   $"{_currentFlight.Destination}");
            //FlightsListBox.Items.Clear();
            //SortFlights(_flights);
            //foreach (var flight in _flights)
            //{
            //    FlightsListBox.Items.Add($"{flight.DepartureTime}: {flight.Departure} - " +
            //        $"{flight.Destination}");
            //}
            FlightsListBox.SelectedIndex = _flights.Count - 1;
        }

        private void RemovePictureBox_Click(object sender, EventArgs e)
        {
            int selectedIndex = FlightsListBox.SelectedIndex;
            if (_flights.Count != 0 && selectedIndex >= 0)
            {
                _flights.RemoveAt(selectedIndex);
                FlightsListBox.Items.Remove(FlightsListBox.SelectedItem);
                FlightsListBox.SelectedIndex = selectedIndex - 1;
            }
        }

        private void UpdatePickureBox_Click(object sender, EventArgs e)
        {
            var index = FlightsListBox.SelectedIndex;
            FlightsListBox.Items.Clear();
            SortFlights();
            foreach (var flight in _flights)
            {
                FlightsListBox.Items.Add(GetInfoFlight(flight));
            }
            FlightsListBox.SelectedIndex = index;
        }
    }
}
