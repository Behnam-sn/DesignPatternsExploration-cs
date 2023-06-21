namespace SingletonPattern
{
    public class Singleton
    {
        private static Singleton? uniqueInstance;

        private Singleton()
        {
        }

        public static Singleton GetInstance()
        {
            uniqueInstance ??= new();
            return uniqueInstance;
        }
    }
}