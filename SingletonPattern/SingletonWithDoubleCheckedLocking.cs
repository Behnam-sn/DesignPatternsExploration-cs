namespace SingletonPattern
{
    public class SingletonWithDoubleCheckedLocking
    {
        private static SingletonWithDoubleCheckedLocking? uniqueInstance;
        private static readonly object lockObject = new();

        private SingletonWithDoubleCheckedLocking()
        {
        }

        public static SingletonWithDoubleCheckedLocking GetInstance()
        {
            if (uniqueInstance != null) return uniqueInstance;
            lock (lockObject)
            {
                if (uniqueInstance != null) return uniqueInstance;
                uniqueInstance = new();
                return uniqueInstance;
            }
        }
    }
}