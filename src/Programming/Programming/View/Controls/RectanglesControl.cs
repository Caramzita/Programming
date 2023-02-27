using System;
using System.Windows.Forms;
using Programming.Model.Classes.Geometry;
using Programming.Model.Classes;

namespace Programming.View.Controls
{
    public partial class RectanglesControl : UserControl
    {
        /// <summary>
        /// Создает массив из 5 предметов экземпляра класса <see cref="Rectangle"/>.
        /// </summary>
        private Rectangle[] _rectanglesArray = new Rectangle[5];

        /// <summary>
        /// Хранит данные о выбранном прямоугольнике класса <see cref="Rectangle"/>.
        /// </summary>
        private Rectangle _currentRectangle;

        /// <summary>
        /// Создает прямоугольники.
        /// </summary>
        public RectanglesControl()
        {
            InitializeComponent();
            MakeRectangles();
            RectanglesListBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Генерирует случайный прямоугольник класса <see cref="Rectangle"/>.
        /// </summary>
        private void MakeRectangles()
        {
            {
                for (int i = 0; i < _rectanglesArray.Length; i++)
                {
                    _rectanglesArray[i] = RectangleFactory.Randomize(250, 250);
                    RectanglesListBox.Items.Add($"Rectangle {i + 1}");
                }
            }
        }

        /// <summary>
        /// Определяет прямоугольник с наибольшей шириной.
        /// </summary>
        /// <param name="rectangles">Список прямоугольников.</param>
        /// <returns>Возвращает индекс подходящего прямоугольника.</returns>
        private int FindRectangleWithMaxWidth(Rectangle[] rectangles)
        {
            int currentIndex = -1;
            double max = 0;
            for (int i = 0; i < rectangles.Length; i++)
            {
                if (rectangles[i].Width > max)
                {
                    max = rectangles[i].Width;
                    currentIndex = i;
                }
            }
            return currentIndex;
        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedIndex = RectanglesListBox.SelectedIndex;
            _currentRectangle = _rectanglesArray[selectedIndex];
            LengthTextBox.Text = _currentRectangle.Length.ToString();
            WidthTextBox.Text = _currentRectangle.Width.ToString();
            ColorTextBox.Text = _currentRectangle.Color;
            XcordTextBox.Text = _currentRectangle.Center.X.ToString();
            YcordTextBox.Text = _currentRectangle.Center.Y.ToString();
            IdTextBox.Text = _currentRectangle.Id.ToString();
        }

        private void LengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Length = Double.Parse(LengthTextBox.Text);
                LengthTextBox.BackColor = AppColors.CorrectColor;
                ToolTip.SetToolTip(LengthTextBox, "");
            }
            catch (Exception exception)
            {
                LengthTextBox.BackColor = AppColors.ErrorColor;
                ToolTip.SetToolTip(LengthTextBox, exception.Message);
                return;
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Width = Double.Parse(WidthTextBox.Text);
                ToolTip.SetToolTip(WidthTextBox, "");
                WidthTextBox.BackColor = AppColors.CorrectColor;
            }
            catch (Exception exception)
            {
                WidthTextBox.BackColor = AppColors.ErrorColor;
                ToolTip.SetToolTip(WidthTextBox, exception.Message);
                return;
            }
        }

        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentRectangle.Color = ColorTextBox.Text;
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            RectanglesListBox.SelectedIndex = FindRectangleWithMaxWidth(_rectanglesArray);
        }
    }
}
