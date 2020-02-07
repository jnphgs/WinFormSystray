using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormSystray
{
    static class Program
    {
        private static NotifyForm notifyForm;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            notifyForm = new NotifyForm();
            Application.Run();
        }
    }
}
