namespace SingletonPattern
{
    public class SingletonWithEagerInstantiation
    {
        private static SingletonWithEagerInstantiation uniqueInstance = new();

        private SingletonWithEagerInstantiation()
        {
        }

        public static SingletonWithEagerInstantiation GetInstance()
        {
            return uniqueInstance;
        }
    }
}