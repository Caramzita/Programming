using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Programming.Model.Classes;
using Programming.Model.Classes.Geometry;

namespace Programming.View.Controls
{  
    public partial class RectanglesCollisionControl : UserControl
    {   
        /// <summary>
        /// Список всех прямоугольников.
        /// </summary>
        private List<Panel> _rectanglePanels;

        /// <summary>
        /// Хранит данные о выбранном прямоугольнике класса <see cref="Rectangle"/>..
        /// </summary>
        private Model.Classes.Geometry.Rectangle _currentRectangle;

        /// <summary>
        /// Изображение кнопки добавления.
        /// </summary>
        private Image _pictureAddLeave = Properties.Resources.plus;

        /// <summary>
        /// Изображение активной кнопки добавления.
        /// </summary>
        private Image _pictureAddMove = Properties.Resources.plus_correct;

        /// <summary>
        /// Изображение кнопки удаления.
        /// </summary>
        private Image _pictureRemoveLeave = Properties.Resources.minus;

        /// <summary>
        /// Изображения активной кнопки удаления.
        /// </summary>
        private Image _pictureRemoveMove = Properties.Resources.minus_remove;

        /// <summary>
        /// Список прямоугольников класса <see cref="Rectangle"/>.
        /// </summary>
        private List<Model.Classes.Geometry.Rectangle> _rectangles;


        /// <summary>
        /// Создает экземпляр <see cref="RectanglesCollisionControl"/>. 
        /// </summary>
        public RectanglesCollisionControl()
        {
            InitializeComponent();
            _rectangles = new List<Model.Classes.Geometry.Rectangle>();
            _rectanglePanels = new List<Panel>();
        }

        /// <summary>
        /// Проверяет на пересечения прямоугольников.
        /// </summary>
        /// <param name="rectangle">Список прямоугольников класса <see cref="Rectangle"/>..</param>
        private void FindCollisions(List<Model.Classes.Geometry.Rectangle> rectangle)
        {
            for (int i = 0; i < _rectangles.Count; i++)
            {
                _rectanglePanels[i].BackColor = AppColors.CorrectColorRectangle;
            }
            for (int i = 0; i < _rectangles.Count; i++)
            {
                for (int j = i + 1; j < _rectangles.Count; j++)
                {
                    if (CollisionManager.IsCollision(rectangle[i], rectangle[j]))
                    {
                        _rectanglePanels[i].BackColor = AppColors.ErrorColorRectangle;
                        _rectanglePanels[j].BackColor = AppColors.ErrorColorRectangle;
                    }
                }
            }
        }

        /// <summary>
        /// Обновляет данные прямоугольника при их изменении.
        /// </summary>
        /// <param name="rectangle">Выбранный прямоугольник класса <see cref="Rectangle"/>.</param>
        private void UpdateRectangleInfo(Model.Classes.Geometry.Rectangle rectangle)
        {
            IdPanelTextBox.Text = rectangle.Id.ToString();
            XPanelTextBox.Text = rectangle.Center.X.ToString();
            YPanelTextBox.Text = rectangle.Center.Y.ToString();
            WidthPanelTextBox.Text = rectangle.Length.ToString();
            HeightPanelTextBox.Text = rectangle.Width.ToString();
        }

        /// <summary>
        /// Обновляет данные в <see cref="RectanglesPanelListBox"/>.
        /// </summary>
        private void UpdateInfo()
        {
            RectanglesPanelListBox.Items[RectanglesPanelListBox.SelectedIndex] =
                SetInfo(_currentRectangle);
        }

        /// <summary>
        /// При отсутсвии выбранного прямоугольника очищает поля.
        /// </summary>
        private void ClearRectangleInfo()
        {
            IdPanelTextBox.Clear();
            XPanelTextBox.Clear();
            XPanelTextBox.BackColor = AppColors.CorrectColor;
            YPanelTextBox.Clear();
            YPanelTextBox.BackColor = AppColors.CorrectColor;
            WidthPanelTextBox.Clear();
            WidthPanelTextBox.BackColor = AppColors.CorrectColor;
            HeightPanelTextBox.Clear();
            HeightPanelTextBox.BackColor = AppColors.CorrectColor;
        }

        /// <summary>
        /// Создает строку со значениями прямоугольников класса <see cref="Rectangle"/>.
        /// </summary>
        /// <param name="rectangle">Выбранный прямоугольник.</param>
        /// <returns></returns>
        private string SetInfo(Model.Classes.Geometry.Rectangle rectangle)
        {
            return ($"{rectangle.Id}: " +
                $"(X = {rectangle.Center.X}; " +
                $"Y = {rectangle.Center.Y}; " +
                $"W = {rectangle.Length}; " +
                $"H = {rectangle.Width})");
        }

        private void RectanglesPanelListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle = _rectangles[RectanglesPanelListBox.SelectedIndex];
                UpdateRectangleInfo(_currentRectangle);
            }
            catch
            {
                ClearRectangleInfo();
            }
        }

        private void XPanelTextBox_TextChanged(object sender, EventArgs e)
        {
            var selectedIndex = RectanglesPanelListBox.SelectedIndex;
            try
            {
                _currentRectangle.Center.X = Int32.Parse(XPanelTextBox.Text);
                _rectanglePanels[selectedIndex].Location = new Point(_currentRectangle.Center.X,
                    _currentRectangle.Center.Y);
                FindCollisions(_rectangles);
                UpdateInfo();
                ToolTip.SetToolTip(XPanelTextBox, "");
                XPanelTextBox.BackColor = AppColors.CorrectColor;
            }
            catch (Exception exception)
            {
                XPanelTextBox.BackColor = AppColors.ErrorColor;
                ToolTip.SetToolTip(XPanelTextBox, exception.Message);
                return;
            }
        }

        private void YPanelTextBox_TextChanged(object sender, EventArgs e)
        {
            var selectedIndex = RectanglesPanelListBox.SelectedIndex;
            try
            {
                _currentRectangle.Center.Y = Int32.Parse(YPanelTextBox.Text);
                _rectanglePanels[selectedIndex].Location = new Point(_currentRectangle.Center.X,
                    _currentRectangle.Center.Y);
                FindCollisions(_rectangles);
                ToolTip.SetToolTip(YPanelTextBox, "");
                YPanelTextBox.BackColor = AppColors.CorrectColor;
                UpdateInfo();
            }
            catch (Exception exception)
            {
                YPanelTextBox.BackColor = AppColors.ErrorColor;
                ToolTip.SetToolTip(YPanelTextBox, exception.Message);
                return;
            }
        }

        private void WidthPanelTextBox_TextChanged(object sender, EventArgs e)
        {
            var selectedIndex = RectanglesPanelListBox.SelectedIndex;
            try
            {
                _currentRectangle.Length = Int32.Parse(WidthPanelTextBox.Text);
                _rectanglePanels[selectedIndex].Size = new Size((int)_currentRectangle.Length,
                    (int)_currentRectangle.Width);
                FindCollisions(_rectangles);
                ToolTip.SetToolTip(WidthPanelTextBox, "");
                WidthPanelTextBox.BackColor = AppColors.CorrectColor;
                UpdateInfo();
            }
            catch (Exception exception)
            {
                WidthPanelTextBox.BackColor = AppColors.ErrorColor;
                ToolTip.SetToolTip(WidthPanelTextBox, exception.Message);
                return;
            }
        }

        private void HeightPanelTextBox_TextChanged(object sender, EventArgs e)
        {
            var selectedIndex = RectanglesPanelListBox.SelectedIndex;
            try
            {
                _currentRectangle.Width = Int32.Parse(HeightPanelTextBox.Text);
                _rectanglePanels[selectedIndex].Size = new Size((int)_currentRectangle.Length,
                    (int)_currentRectangle.Width);
                FindCollisions(_rectangles);
                ToolTip.SetToolTip(HeightPanelTextBox, "");
                HeightPanelTextBox.BackColor = AppColors.CorrectColor;
                UpdateInfo();
            }
            catch (Exception exception)
            {
                HeightPanelTextBox.BackColor = AppColors.ErrorColor;
                ToolTip.SetToolTip(HeightPanelTextBox, exception.Message);
                return;
            }
        }

        private void RectanlgeAddPictureBox_Click(object sender, EventArgs e)
        {
            _currentRectangle = RectangleFactory.Randomize(RectanglesPanel.Width - 50, 
                RectanglesPanel.Height - 50);
            _rectangles.Add(_currentRectangle);
            RectanglesPanelListBox.Items.Add(SetInfo(_currentRectangle));
            Panel panel = new Panel();
            panel.Location = new Point(_currentRectangle.Center.X + (int)_currentRectangle.Length / 2,
                _currentRectangle.Center.Y + (int)_currentRectangle.Width / 2);
            panel.Size = new Size((int)_currentRectangle.Length, (int)_currentRectangle.Width);
            _rectanglePanels.Add(panel);
            FindCollisions(_rectangles);
            RectanglesPanel.Controls.Add(panel);
            RectanglesPanelListBox.SelectedIndex = _rectangles.Count - 1;
            try
            {
                _currentRectangle = _rectangles[RectanglesPanelListBox.SelectedIndex];
                UpdateRectangleInfo(_currentRectangle);
            }
            catch
            {
                ClearRectangleInfo();
            }
        }

        private void RectangleRemovePictureBox_Click(object sender, EventArgs e)
        {
            int index = RectanglesPanelListBox.SelectedIndex;
            if (_rectangles.Count != 0 && index >= 0)
            {
                _rectangles.RemoveAt(RectanglesPanelListBox.SelectedIndex);
                _rectanglePanels.RemoveAt(index);
                RectanglesPanelListBox.Items.Remove(RectanglesPanelListBox.SelectedItem);
                RectanglesPanel.Controls.RemoveAt(index);
                RectanglesPanelListBox.SelectedIndex = index - 1;
            }
            FindCollisions(_rectangles);
            try
            {
                _currentRectangle = _rectangles[RectanglesPanelListBox.SelectedIndex];
                UpdateRectangleInfo(_currentRectangle);
            }
            catch
            {
                ClearRectangleInfo();
            }
        }

        private void RectanlgeAddPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            RectanlgeAddPictureBox.BackgroundImage = _pictureAddMove;
        }

        private void RectanlgeAddPictureBox_MouseLeave(object sender, EventArgs e)
        {
            RectanlgeAddPictureBox.BackgroundImage = _pictureAddLeave;
        }

        private void RectangleRemovePictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            RectangleRemovePictureBox.BackgroundImage = _pictureRemoveMove;
        }

        private void RectangleRemovePictureBox_MouseLeave(object sender, EventArgs e)
        {
            RectangleRemovePictureBox.BackgroundImage = _pictureRemoveLeave;
        }
    }
}
