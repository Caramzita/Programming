using System;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о песне: название, исполнитель, продолжительность.
    /// </summary>
    public class Song
    {
        /// <summary>
        /// Хранит продолжительность песни.
        /// </summary>
        private double _duration;

        /// <summary>
        /// Создает пустой экземпляр класса <see cref="Song"/>.
        /// </summary>
        public Song()
        {
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Song"/>.
        /// </summary>
        /// <param name="name">Название песни.</param>
        /// <param name="artist">Имя исполнителя.</param>
        /// <param name="duration">Продолжительность песни. Должна быть положительной.</param>
        public Song(string name,
            string artist,
            double duration)
        {
            Name = name;
            Artist = artist;
            Duration = duration;
        }

        /// <summary>
        /// Возвращает и задает продолжительность песни. Должна быть положительной.
        /// </summary>
        public double Duration
        {
            get
            {
                return _duration;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Duration));
                _duration = value;
            }
        }

        /// <summary>
        /// Возвращает и задает название песни.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Возвращает и задает имя исполнителя.
        /// </summary>
        public string Artist { get; set; }
    }
}
