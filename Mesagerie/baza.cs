using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace atestat
{
    public partial class baza : Form
    {
        public baza()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            if (!db.check_connection())
            {
                eroareBazaDate m = new eroareBazaDate();
                m.Show();
                this.Hide();
            }
            else
            { 
                Login l = new Login();
                l.Show();
            }

        }

        private void baza_Load(object sender, EventArgs e)
        {
            
        }
    }
}
