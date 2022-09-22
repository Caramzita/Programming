namespace ObjectOrientedPractics.Services
{
    static class IdGenerator
    {
        private static int _allCount;

        private static int _id;

        public static int GetNextId()
        {
            _allCount++;
            _id = _allCount;

            return _id;
        }
    }
}
