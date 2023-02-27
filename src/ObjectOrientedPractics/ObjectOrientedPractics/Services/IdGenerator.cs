using System;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Создает уникальный идентификатор.
    /// </summary>
    public static class IdGenerator
    {
        /// <summary>
        /// Хранит общее количество данных.
        /// </summary>
        private static int _allCount = 0;

        /// <summary>
        /// Уникальный идентификатор.
        /// </summary>
        private static int _id;

        /// <summary>
        /// Создает уникальный идентификатор.
        /// </summary>
        /// <returns>Уникальный идентификатор.</returns>
        public static int GetNextId()
        {
            _allCount++;
            _id = _allCount;

            return _id;
        }
    }
}
