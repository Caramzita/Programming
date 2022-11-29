using System;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о дисциплине: название, имя преподавателя, оценка.
    /// </summary>
    public class Subject
    {
        /// <summary>
        /// Создает пустой экземпляр класса <see cref="Subject"/>.
        /// </summary>
        public Subject()
        {
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Subject"/>.
        /// </summary>
        /// <param name="name">Название дисциплины.</param>
        /// <param name="teacherName">Имя преподавателя.</param>
        /// <param name="grade">Оценка. Должна быть положительной.</param>
        public Subject(string name,
            string teacherName,
            double grade)
        {
            Name = name;
            TeacherName = teacherName;
            Grade = grade;
        }

        /// <summary>
        /// Возвращает и задает название дисциплины.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Возвращает и задает имя преподавателя.
        /// </summary>
        public string TeacherName { get; set; }

        /// <summary>
        /// Возвращает и задает оценку. Должна быть положительной.
        /// </summary>
        public double Grade { get; set; }
    }
}
