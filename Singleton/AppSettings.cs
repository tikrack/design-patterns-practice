namespace Singleton
{
    internal class AppSettings
    {
        private static AppSettings? _instance;

        public static AppSettings Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AppSettings();
                }

                return _instance;
            }
        }


        private AppSettings() {}

        public string Title { get; set; } = "Test";
        public Color BackgroundColor { get; set; } = Color.Blue;
    }
}
