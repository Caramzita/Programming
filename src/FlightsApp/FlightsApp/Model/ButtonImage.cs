using System.Drawing;

namespace FlightsApp.Model
{
    /// <summary>
    /// Хранит изображения PictureBox.
    /// </summary>
    public static class ButtonImage
    {
        /// <summary>
        /// Изображения добавления перелетов.
        /// </summary>
        public static Image AddPicture = Properties.Resources.AddButton;

        /// <summary>
        /// Изображения активной кнопки добавления перелетов.
        /// </summary>
        public static Image ActiveAddPicture = Properties.Resources.ActiveAddButton;

        /// <summary>
        /// Изображения удаления перелетов.
        /// </summary>
        public static Image RemovePicture = Properties.Resources.RemoveButton;

        /// <summary>
        /// Изображения активной кнопки удаления перелетов.
        /// </summary>
        public static Image ActiveRemovePicture = Properties.Resources.ActiveRemoveButton;
    }
}
