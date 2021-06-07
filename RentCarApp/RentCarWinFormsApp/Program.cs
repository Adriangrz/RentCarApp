using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCarWinFormsApp
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var sc = new ServiceCollection()
                .AddSingleton<MainCarRentalForm>()
                .AddSingleton<CarRentalTimeRangeUserControl>()
                .AddSingleton<SelectingCarForRentalUserControl>()
                .AddSingleton<CustomerDataUserControl>()
                .AddSingleton<CarRentalConfirmationUserControl>();
            var sp = sc.BuildServiceProvider();

            Application.Run(sp.GetService<MainCarRentalForm>());
        }
    }
}
