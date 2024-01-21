namespace FDJAnalyzer
{
    internal static class Program
    {
        public static EuroMillionsManager euroMillions = new EuroMillionsManager();
        [STAThread]

        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new form());
        }
    }
}