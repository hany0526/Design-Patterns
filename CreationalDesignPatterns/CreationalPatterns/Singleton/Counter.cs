namespace CreationalDesignPatterns.CreationalPatterns.Singleton
{
    public class Counter
    {
        public int count = 0;
        private static Counter instance = null;
        private static object lockObj = new object();
        private Counter() { }

        // lazy initialization
        public static Counter GetInstance()
        {
            if (instance == null)
            {
                lockObj ??= new object();

                lock (lockObj)
                {
                    instance = new Counter();
                }
            }

            return instance;
        }

        // third safety Singleton Pattern implementation
        public static Counter GetHanyInstance()
        {
            // if (instance != null) return instance;

            lock (lockObj)
            {
                return instance ??= new Counter();
            }
        }

        public void AddOne()
        {
            count++;
        }

    }
}