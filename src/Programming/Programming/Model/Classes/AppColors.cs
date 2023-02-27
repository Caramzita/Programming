using System.Drawing;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит цвета.
    /// </summary>
    static class AppColors
    {
        /// <summary>
        /// Цвет ошибки.
        /// </summary>
        public static readonly Color ErrorColor = Color.LightPink;

        /// <summary>
        /// Правильный цвет.
        /// </summary>
        public static readonly Color CorrectColor = Color.White;
        
        /// <summary>
        /// Цвет непересечения прямоугольников.
        /// </summary>
        public static readonly Color CorrectColorRectangle = Color.FromArgb(127, 127, 255, 127);
        
        /// <summary>
        /// Цвет пересечения прямоугольников.
        /// </summary>
        public static readonly Color ErrorColorRectangle = Color.FromArgb(127, 255, 127, 127);

        /// <summary>
        /// Цвет весны.
        /// </summary>
        public static readonly Color SpringColor = ColorTranslator.FromHtml("#559c45");

        /// <summary>
        /// Цвет осени.
        /// </summary>
        public static readonly Color AutumnColor = ColorTranslator.FromHtml("#e29c45");
    }
}
