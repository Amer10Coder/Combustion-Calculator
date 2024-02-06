using System.Runtime.InteropServices;

namespace Combustion_Calculator
{
    internal static class Program
    {
        // Unique name for the mutex (change this as per your application)
        private static string mutexName = "Combustion Calculator_SingleInstanceMutex";

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            // Check if another instance is already running
            using (Mutex mutex = new Mutex(true, mutexName, out bool createdNew))
            {
                if (createdNew)
                {
                    ApplicationConfiguration.Initialize();
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(true);
                    Application.Run(new MainForm());
                }
                else
                {
                    // Another instance is already running, so bring it to foreground
                    IntPtr handle = FindWindow(null, "Combustion Calculator"); // Update the title of your form
                    if (handle != IntPtr.Zero)
                    {
                        ShowWindow(handle, SW_RESTORE);
                        SetForegroundWindow(handle);
                    }
                }
            }
        }
        // Import necessary Windows API functions
        [DllImport("user32.dll")]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        private const int SW_RESTORE = 9;
    }
}
