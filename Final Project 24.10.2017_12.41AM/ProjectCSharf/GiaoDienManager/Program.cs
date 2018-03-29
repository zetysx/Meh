using ProjectCSharp;
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
        private static string username = "";

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

        public static string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
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
