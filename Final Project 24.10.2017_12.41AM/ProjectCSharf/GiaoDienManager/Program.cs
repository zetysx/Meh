using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDienManager
{
    public static class RoleForFrom
    {
        private static string role = "";

        public static string Role
        {
            get
            {
                return role;
            }

            set
            {
                role = value;
            }
        }
    }

    
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
