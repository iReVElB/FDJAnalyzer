namespace FDJAnalyzer
{
    internal static class Program
    {
        public static EuroMillions euroMillions = new EuroMillions();
        [STAThread]

        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new form());
        }
    }
}