using System;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;

namespace InlineSkatesApp
{
    internal static class Program
    {
        public static IConfiguration Configuration;

        [STAThread]
        static void Main()
        {
            var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            Configuration = builder.Build();

            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(Configuration.GetValue<string>("AppSettings:SyncfusionToken"));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}
