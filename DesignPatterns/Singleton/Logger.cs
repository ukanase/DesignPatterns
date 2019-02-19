namespace DesignPatterns.Singleton
{
    public class Logger
    {
        private static Logger _instance { get; set; }

        private static object synchronizationObject = new object();

        private Logger()
        {

        }

        public static Logger GetLogger()
        {
            if (_instance == null)
            {
                lock (synchronizationObject)
                {
                    if (_instance == null)
                    {
                        _instance = new Logger();
                    }
                }
            }

            return _instance;
        }

    }
}
