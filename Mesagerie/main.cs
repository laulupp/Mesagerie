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
    public partial class main : Form
    {
        int id;
        string cerere_user1, cerere_user2;
        int nr_prieteni;

        public main(int id)
        {
            InitializeComponent();
            this.id = id;
            Username.Text = f.getprenume(id);
            f.nr_cereri = 0;
            nr_prieteni = f.numar_prieteni(f.getusername(id));
            f.afisare_prieteni(panel_prieteni, id, nu_prieteni, panel_setari, panel_mijloc, panel_adauga_prieten, cereri_prietenie, mesagerie, nume_destinatar, mesaje, mesaj, t);
            t2.Start();
        }

        public void afisare_mesaje()
        {
            string user1 = f.getusername(id);
            string user2 = f.user2;
            for (int i = 0; i < f.nr_mesaje; i++)
            {
                mesaje.Controls.Remove(f.mesaje[i]);
            }
            f.nr_mesaje = 0;
            f.current_h = 0;
            
            //mesaj panel
            MySqlCommand cmd1 = new MySqlCommand("SELECT COUNT(*) FROM mesaje WHERE username1 = '" + user2 + "' AND username2 = '" + user1 + "' OR username1 = '" + user1 + "' AND username2 = '" + user2 + "'", db.con);
            int n = Convert.ToInt32(cmd1.ExecuteScalar());

            if (n != 0)
            {
                f.mesaje = new Label[n];
                MySqlCommand cmd2 = new MySqlCommand("SELECT mesaj,username1 FROM mesaje WHERE username1 = '" + user2 + "' AND username2 = '" + user1 + "' OR username1 = '" + user1 + "' AND username2 = '" + user2 + "'", db.con);
                MySqlDataReader r = cmd2.ExecuteReader();

                while (r.Read())
                {
                    f.mesaje[f.nr_mesaje] = new Label();
                    f.mesaje[f.nr_mesaje].BackColor = mesaje.BackColor;
                    mesaje.Controls.Add(f.mesaje[f.nr_mesaje]);
                    f.mesaje[f.nr_mesaje].Text = r["mesaj"].ToString();
                    f.mesaje[f.nr_mesaje].AutoSize = true;
                    f.mesaje[f.nr_mesaje].MaximumSize = new Size(Convert.ToInt32(mesaje.Size.Width * 40 / 100), 0);
                    f.mesaje[f.nr_mesaje].Font = new Font("MS Reference Sans Serif", 10, FontStyle.Bold);
                    if (user1 != r["username1"].ToString())
                    {
                        f.mesaje[f.nr_mesaje].Location = new Point(30, f.current_h + 15);
                        f.mesaje[f.nr_mesaje].TextAlign = ContentAlignment.MiddleLeft;
                    }
                    else
                    {
                        f.mesaje[f.nr_mesaje].Location = new Point(mesaje.Size.Width - f.mesaje[f.nr_mesaje].Size.Width - 30, f.current_h + 15);
                        f.mesaje[f.nr_mesaje].TextAlign = ContentAlignment.MiddleRight;
                    }


                    f.current_h += f.mesaje[f.nr_mesaje].Size.Height + 10;
                    f.nr_mesaje++;
                }
                mesaje.ScrollControlIntoView(f.mesaje[f.nr_mesaje - 1]);

                r.Close();
            }
        }

        private void iesire_login_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Close();
        }

        private void setari_Click(object sender, EventArgs e)
        {
            mesagerie.Visible = false;
            panel_setari.Visible = true;
            panel_mijloc.Visible = false;
            panel_adauga_prieten.Visible = false;
            cereri_prietenie.Visible = false;
            t.Stop();
            nume.Text = "";
            prenume.Text = "";
            pass.Text = "";
            pass_veche.Text = "";
        }

        private void actualizeaza1_Click(object sender, EventArgs e)
        {
            if (f.check_password(id, pass_veche.Text))
            {
                if (nume.Text.Length <= 1)
                {
                    MessageBox.Show("Numele trebuie sa aiba minim 2 caractere");
                }
                else
                {
                    f.setnume(id, nume.Text);
                    MessageBox.Show("Numele a fost schimbat !");
                }
            }
            else
            {
                MessageBox.Show("Parola curenta incorecta !");
            }
        }

        private void actualizeaza2_Click(object sender, EventArgs e)
        {
            if (f.check_password(id, pass_veche.Text))
            {
                if (prenume.Text.Length <= 1)
                {
                    MessageBox.Show("Prenumele trebuie sa aiba minim 2 caractere");
                }
                else
                {
                    f.setprenume(id, prenume.Text);
                    MessageBox.Show("Prenumele a fost schimbat !");
                    Username.Text = f.getprenume(id);
                }
            }
            else
            {
                MessageBox.Show("Parola curenta incorecta !");
            }
        }

        private void actualizeaza3_Click(object sender, EventArgs e)
        {
            if (f.check_password(id, pass_veche.Text))
            {
                if (pass.Text.Length < 5 || pass.Text.Length > 254)
                {
                    MessageBox.Show("Parola trebuie sa aiba intre 5 si 254 de caractere");
                }
                else
                {
                    f.setpass(id, f.crypt(pass.Text));
                    MessageBox.Show("Parola a fost schimbata !");
                    pass.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Parola curenta incorecta !");
            }
        }

        private void panel_adauga_prieten_Paint(object sender, PaintEventArgs e)
        {

        }

        private void adaugaprieten_Click_1(object sender, EventArgs e)
        {
            mesagerie.Visible = false;
            panel_setari.Visible = false;
            panel_mijloc.Visible = false;
            cereri_prietenie.Visible = false;
            panel_adauga_prieten.Visible = true;
            t.Stop();
        }

        private void button_WOC1_Click_1(object sender, EventArgs e)
        {
            resultat_cautare.Visible = false;
            result_existent.Visible = false;
            result_ok.Visible = false;
            result_inexistent.Visible = false;
            if (user_cautat.Text != f.getusername(id))
            {
                if (f.check_username(user_cautat.Text))
                {
                    if (!f.exista_prietenie(user_cautat.Text, f.getusername(id)))
                    {
                        if (!f.exista_cererea(f.getusername(id), user_cautat.Text))
                        {
                            cerere_user1 = f.getusername(id);
                            cerere_user2 = user_cautat.Text;
                            nume_cautare.Text = f.getname(f.getid(user_cautat.Text)) + " " + f.getprenume(f.getid(user_cautat.Text));
                            result_existent.Visible = false;
                            result_ok.Visible = true;
                            resultat_cautare.Visible = true;
                            result_inexistent.Visible = false;
                        }
                        else
                        {
                            resultat_cautare.Visible = false;
                            result_existent.Visible = true;
                            result_ok.Visible = false;
                            result_inexistent.Visible = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Deja sunteti prieteni!");
                    }
                }
                else
                {
                    resultat_cautare.Visible = false;
                    result_existent.Visible = false;
                    result_ok.Visible = false;
                    result_inexistent.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Nu te poti cauta pe tine !");
            }
        }

        private void cereriprietenie_Click(object sender, EventArgs e)
        {
            mesagerie.Visible = false;
            panel_setari.Visible = false;
            panel_mijloc.Visible = false;
            cereri_prietenie.Visible = true;
            panel_adauga_prieten.Visible = false;
            t.Stop();

            nu_exista_cereri_active.Visible = false;
            //cereri_prietenie.Controls.Add(new cerere_prietene());
            if (f.exista_cereri_active(f.getusername(id)))
            {
                for (int i = 0; i < f.nr_cereri; i++)
                {
                    cereri_prietenie.Controls.Remove(f.cereri[i]);
                }

                f.cereri = new cerere_prietene[f.nr_cereri_active(f.getusername(id))];
                f.nr_cereri = 0;

                string user = f.getusername(id);

                MySqlCommand cmd = new MySqlCommand("SELECT username,nume,prenume FROM users WHERE username IN (SELECT username1 FROM requests WHERE username2 = '" + f.getusername(id) + "')", db.con);
                MySqlDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    f.cereri[f.nr_cereri] = new cerere_prietene(r["nume"].ToString() + " " + r["prenume"].ToString(), user, r["username"].ToString(), f.nr_cereri, cereriprietenie, panel_prieteni, id, nu_prieteni, panel_setari, panel_mijloc, panel_adauga_prieten, cereri_prietenie, mesagerie, nume_destinatar, mesaje, mesaj, t);
                    cereri_prietenie.Controls.Add(f.cereri[f.nr_cereri]);
                    f.cereri[f.nr_cereri].Location = new Point(Convert.ToInt32((cereri_prietenie.Width - f.cereri[f.nr_cereri].Width) / 2 - 20), f.nr_cereri * (10 + f.cereri[f.nr_cereri].Height) + 10);
                    Refresh();
                    f.nr_cereri++;
                }
                r.Close();
            }
            else
            {
                if (f.nr_cereri == 1)
                {
                    cereri_prietenie.Controls.Remove(f.cereri[0]);
                    f.nr_cereri = 0;
                }
                nu_exista_cereri_active.Visible = true;
            }
        }

        private void acasa_Click(object sender, EventArgs e)
        {
            panel_setari.Visible = false;
            panel_mijloc.Visible = true;
            cereri_prietenie.Visible = false;
            panel_adauga_prieten.Visible = false;
            mesagerie.Visible = false;
            t.Stop();
            nu_exista_cereri_active.Visible = false;
        }

        private void sendmsg_Click(object sender, EventArgs e)
        {
            if (mesaj.Text == "")
            {
                MessageBox.Show("Trebuie sa completezi un mesaj!");
            }
            else if (mesaj.Text.Length > 254)
            {
                MessageBox.Show("Mesajul este prea lung!");
            }
            else
            {
                f.trimite_mesaj(f.getusername(id), f.user2, mesaj.Text);
                mesaj.Text = "";
                afisare_mesaje();
            }
        }
        private void refersh_mesaje()
        {
            string user1 = f.getusername(id);
            for (int i = 0; i < f.nr_mesaje; i++)
            {
                mesaje.Controls.Remove(f.mesaje[i]);
            }
            f.nr_mesaje = 0;
            f.current_h = 0;
            
            //mesaj panel
            MySqlCommand cmd1 = new MySqlCommand("SELECT COUNT(*) FROM mesaje WHERE username1 = '" + f.user2 + "' AND username2 = '" + user1 + "' OR username1 = '" + user1 + "' AND username2 = '" + f.user2 + "'", db.con);
            int n = Convert.ToInt32(cmd1.ExecuteScalar());

            if (n != 0)
            {
                f.mesaje = new Label[n];
                MySqlCommand cmd2 = new MySqlCommand("SELECT mesaj,username1 FROM mesaje WHERE username1 = '" + f.user2 + "' AND username2 = '" + user1 + "' OR username1 = '" + user1 + "' AND username2 = '" + f.user2 + "'", db.con);
                MySqlDataReader r = cmd2.ExecuteReader();

                while (r.Read())
                {
                    f.mesaje[f.nr_mesaje] = new Label();
                    mesaje.Controls.Add(f.mesaje[f.nr_mesaje]);
                    f.mesaje[f.nr_mesaje].Text = r["mesaj"].ToString();
                    f.mesaje[f.nr_mesaje].AutoSize = true;
                    f.mesaje[f.nr_mesaje].MaximumSize = new Size(Convert.ToInt32(mesaje.Size.Width * 40 / 100), 0);
                    f.mesaje[f.nr_mesaje].Font = new Font("MS Reference Sans Serif", 10, FontStyle.Bold);
                    if (f.user2 != r["username2"].ToString())
                    {
                        f.mesaje[f.nr_mesaje].Location = new Point(25, f.current_h + 15);
                        f.mesaje[f.nr_mesaje].TextAlign = ContentAlignment.MiddleLeft;
                    }
                    else
                    {
                        f.mesaje[f.nr_mesaje].Location = new Point(mesaje.Size.Width - f.mesaje[f.nr_mesaje].Size.Width - 25, f.current_h + 15);
                        f.mesaje[f.nr_mesaje].TextAlign = ContentAlignment.MiddleRight;
                    }

                    f.current_h += f.mesaje[f.nr_mesaje].Size.Height + 15;
                    f.nr_mesaje++;
                }
                mesaje.ScrollControlIntoView(f.mesaje[f.nr_mesaje - 1]);
                Refresh();
                r.Close();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            string user1 = f.getusername(id);
            MySqlCommand cmd1 = new MySqlCommand("SELECT COUNT(*) FROM mesaje WHERE username1 = '" + f.user2 + "' AND username2 = '" + user1 + "' OR username1 = '" + user1 + "' AND username2 = '" + f.user2 + "'", db.con);
            int n = Convert.ToInt32(cmd1.ExecuteScalar());
            if (n != f.nr_mesaje)
            {
                afisare_mesaje();
            }
        }

        private void t2_Tick(object sender, EventArgs e)
        {
            if (f.numar_prieteni(f.getusername(id)) != nr_prieteni)
            {
                f.afisare_prieteni(panel_prieteni, id, nu_prieteni, panel_setari, panel_mijloc, panel_adauga_prieten, cereri_prietenie, mesagerie, nume_destinatar, mesaje, mesaj, t);
                nr_prieteni = f.numar_prieteni(f.getusername(id));
            }
        }
        private void adauga_Click(object sender, EventArgs e)
        {
            f.creare_cerere(cerere_user1, cerere_user2);
            resultat_cautare.Visible = false;
            result_existent.Visible = false;
            result_ok.Visible = false;
            mesagerie.Visible = false;
            result_inexistent.Visible = false;
            MessageBox.Show("Cererea a fost trimisa !");
        }
    }
}
