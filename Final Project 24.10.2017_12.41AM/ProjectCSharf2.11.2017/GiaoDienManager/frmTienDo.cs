using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCSharp
{
    public partial class frmTienDo : Form
    {
        public delegate void ShowLogin();
        public ShowLogin show;
        public static bool checkConnection = false;
        static string constring = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;

        public frmTienDo()
        {
            InitializeComponent();
        }

        private void frmTienDo_Load(object sender, EventArgs e)
        {
            timerCheck.Start();
            backgroundWorker.RunWorkerAsync();
        }

        public void CheckCon()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(constring))
                {
                    con.Open();
                }
                checkConnection = true;
            }
            catch (Exception ex)
            {
                checkConnection = false;
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void timerCheck_Tick(object sender, EventArgs e)
        {
            if (!checkConnection)
            {
                if (pgbProgress.Value == 100)
                {
                    timerCheck.Stop();
                    backgroundWorker.WorkerSupportsCancellation = true;
                    backgroundWorker.CancelAsync();
                    MessageBox.Show("Time out!");
                    Application.Exit();
                }
                else
                {
                    pgbProgress.Increment(10);
                    labelProgress.Text = "Progressing...(" + pgbProgress.Value + "%)";
                }
            }
            else
            {
                timerCheck.Stop();
                /* frmMain main = new frmMain();
                 main.Show();*/
                show?.Invoke();
                this.Hide();

            }
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                //labelProgress.Text = "Progressing...(" + pgbProgress.Value + "%)";
                CheckCon();
            }
            catch (Exception ex)
            {
                timerCheck.Stop();
                MessageBox.Show(ex.Message);
                //Application.Exit();
            }
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pgbProgress.Value = pgbProgress.Maximum;
        }
    }
}
