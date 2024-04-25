namespace MeditationTimerApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new RelaxTimerForm());

        }
        public static string PickMusicFile(int index)
        {
            return index switch
            {
                0 => "thinking.wav",
                1 => "tune2.wav",
                2 => "tune3.wav",
                3 => "tune4.wav",
                4 => "tune5.wav",
                _ => null
            };
        }
    }
}