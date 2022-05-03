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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void iesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void creare_cont_label_Click(object sender, EventArgs e)
        {
            Register r = new Register();
            r.Show();
            this.Close();
        }

        private void eroare_Click(object sender, EventArgs e)
        {

        }

        private void login_button_Click(object sender, EventArgs e)
        {
            if (f.check_connection(this, eroare))
            {
                if (Username.Text != "" && Password.Text != "")
                {
                    if (f.check_username(Username.Text))
                    {
                        if (f.check_password(Username.Text, Password.Text,eroare))
                        {
                            main m = new main(f.getid(Username.Text));
                            m.Show();
                            this.Close();
                        }
                        else
                        {
                            f.settext(this, "Parola gresita", 0, eroare, 5);
                        }
                    }
                    else
                    {
                        f.settext(this, "Username inexistent", 1, eroare, 5);
                    }
                }
                else
                {
                    f.settext(this,"Te rog sa completezi toate campurile", 2,eroare,5);
                }


            }
        }
    }
}
