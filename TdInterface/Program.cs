using Microsoft.Extensions.DependencyInjection;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;


namespace TdInterface
{
    internal static class Program
    {
        /// <summary>
        /// TextWriterTraceListener for the application to use for debug / output logging.
        /// </summary>
        private static TextWriterTraceListener _textWriterTraceListener = null;

        /// <summary>
        /// AppVersion with Major.Minor.Build for display within the application and used to compare versions
        /// </summary>
        /// <example>3.1.17</example>
        public static string AppVersion
        {
            get
            {
                var versionInfo = Assembly.GetExecutingAssembly().GetName().Version;
                return $"{versionInfo.Major}.{versionInfo.Minor}.{versionInfo.Build}";
            }
        }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Set application configuration
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            
            var services = new ServiceCollection();
            ConfigureServices(services);

            // Setup debug trace listener for the application
            string currentPath = Directory.GetCurrentDirectory();
            string logFolder = Path.Combine(currentPath, "logs");
            if (!Directory.Exists(logFolder))
                Directory.CreateDirectory(logFolder);

            _textWriterTraceListener = new TextWriterTraceListener($"{logFolder}\\{DateTime.Now.ToString("yyyyMMdd-HHmmss")}.log");
            Trace.Listeners.Add(_textWriterTraceListener);


            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var masterForm = serviceProvider.GetRequiredService<MasterForm>();
                Application.Run(masterForm);
            }
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddSingleton<MasterForm>();
        }
        /// <summary>
        /// Exit handler for the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void OnExit(object sender, EventArgs e)
        {
            _textWriterTraceListener.Flush();
            _textWriterTraceListener.Close();
            _textWriterTraceListener.Dispose();
        }
    }
}
