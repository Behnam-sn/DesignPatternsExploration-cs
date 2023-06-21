using System.Runtime.CompilerServices;

namespace SingletonPattern
{
    public class SingletonWithSynchronization
    {
        private static SingletonWithSynchronization? uniqueInstance;

        private SingletonWithSynchronization()
        {
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public static SingletonWithSynchronization GetInstance()
        {
            uniqueInstance ??= new();
            return uniqueInstance;
        }
    }
}