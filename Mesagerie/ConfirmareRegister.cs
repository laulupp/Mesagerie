using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atestat
{
    public partial class ConfirmareRegister : Form
    {
        public ConfirmareRegister()
        {
            InitializeComponent();
        }

        private void ConfirmareRegister_Load(object sender, EventArgs e)
        {

        }

        private void login_text_1_Click(object sender, EventArgs e)
        {

        }

        private void back_register_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Close();
        }
    }
}
