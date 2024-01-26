namespace FDJAnalyzer
{
    internal static class Program
    {
        [STAThread]

        static void Main()
        {
            ApplicationConfiguration.Initialize();
            form form = new form();
            form.FormClosing += Form_FormClosing;
            Application.Run(form);
        }

        private static void Form_FormClosing(object? sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}