namespace Coursework_Horbach_program__Form
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
            bool isAuthenticated = GetAuthenticationStatus();
            Application.Run(new Register_or_AuthenticatePage(isAuthenticated));
            static bool GetAuthenticationStatus()
            {
                bool isAuthenticated = false;
                return isAuthenticated;
            }
        }
    }
}