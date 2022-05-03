using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using System.Security.Cryptography;

namespace atestat
{
    static class f
    {
        public static cerere_prietene[] cereri;
        public static int nr_cereri;

        public static prieten[] prieteni;
        public static int nr_prieteni;

        public static string user2;

        public static Label[] mesaje;
        public static int nr_mesaje = 0;
        public static int current_h = 0;
        private static Panel panel_mesaje;
        private static string user1;        

        public static string crypt(string x)
        {
            StringBuilder h = new StringBuilder();
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] b = md5.ComputeHash(new UTF8Encoding().GetBytes(x));

            for (int i = 0; i < b.Length; i++)
            {
                h.Append(b[i].ToString("x2"));
            }
            return h.ToString();
        }

        public static bool check_password(string username, string password, Label a)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT pass FROM users WHERE username='" + username + "'", db.con);
            MySqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                if (crypt(password) != r.GetString(0))
                {
                    r.Close();
                    return false;
                }
            }
            r.Close();
            return true;
        }
        public static bool check_password(int id, string pwd)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT pass FROM users WHERE id ='" + id + "'", db.con);
            MySqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                if (crypt(pwd) != r.GetString(0))
                {
                    r.Close();
                    return false;
                }
            }
            r.Close();
            return true;

        }
        public static bool check_username(string username)//daca exista
        {
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM users WHERE username = '" + username + "'", db.con);
            int n = Convert.ToInt32(cmd.ExecuteScalar());
            if (n == 0)
                return false;
            return true;
        }
        public static bool check_connection(Form x, Label a)
        {
            bool ok = true;
            if (!db.check_connection())
                ok = false;
            if (!ok)
                settext(x, "Nu s-a putut realiza conexiunea la baza de date", 1, a, 5);
            return ok;
        }

        public static bool check_username_requirements(Form x, Label a)
        {
            bool ok = true;
            if (!ok)
                settext(x, "Username-ul este deja folosit", 1, a, 5);
            return ok;
        }
        public static void afisare_prieteni(Panel panel_prieteni,int id,Label nu_prieteni,Panel panel1,Panel panel2,Panel panel3,Panel panel4,Panel mesagerie,Label nume,Panel mesaje,TextBox mesaj,Timer t)
        {
            for (int i = 0; i < f.nr_prieteni; i++)
            {
                panel_prieteni.Controls.Remove(f.prieteni[i]);
            }
            if (f.are_prieteni(f.getusername(id)))
            {
                nu_prieteni.Visible = false;
                f.nr_prieteni = f.numar_prieteni(f.getusername(id));
                f.prieteni = new prieten[f.nr_prieteni];
                f.nr_prieteni = 0;
                string user = f.getusername(id);

                MySqlCommand cmd = new MySqlCommand("SELECT username,nume,prenume FROM users WHERE username IN (SELECT username2 FROM prieteni WHERE username1 = '" + user + "')", db.con);
                MySqlDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    f.prieteni[f.nr_prieteni] = new prieten(r["nume"].ToString() + " " + r["prenume"].ToString(), user, r["username"].ToString(),new Size(panel_prieteni.Width - 76, 36),panel1,panel2,panel3,panel4,mesagerie,nume,mesaje,mesaj,t);
                    panel_prieteni.Controls.Add(f.prieteni[f.nr_prieteni]);
                    f.prieteni[f.nr_prieteni].Location = new Point(38, f.nr_prieteni * (15 + f.prieteni[f.nr_prieteni].Height) + 15);
                    f.nr_prieteni++;
                }
                r.Close();
            }
            else
            {
                nu_prieteni.Visible = true;
            }
        }
        public static void trimite_mesaj(string user1,string user2,string mesaj)
        {
            MySqlCommand cmd = new MySqlCommand("Insert into mesaje (username1,username2,mesaj) values('" + user1 + "','" + user2 + "','" + mesaj + "')", db.con);
            cmd.ExecuteNonQuery();
        }
        public static void creare_user(string nume, string prenume, string username, string parola, Form t, Label a)
        {
            if (!check_username(username))
            {
                MySqlCommand cmd = new MySqlCommand("Insert into users (username,pass,nume,prenume) values('" + username + "','" + crypt(parola) + "','" + nume + "','" + prenume + "')", db.con);
                cmd.ExecuteNonQuery();
                ConfirmareRegister f = new ConfirmareRegister();
                f.Show();
                t.Close();
            }
            else
            {
                settext(t, "Usernameul exista deja", 1, a, 5);
            }
        }
        public static string getname(int id)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT nume FROM users WHERE id='" + id + " limit 1'", db.con);
            MySqlDataReader r = cmd.ExecuteReader();
            string x = "";
            while (r.Read())
            {
                x = r.GetString(0);
            }
            r.Close();
            return x;
        }
        public static string getprenume(int id)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT prenume FROM users WHERE id='" + id + " limit 1'", db.con);
            MySqlDataReader r = cmd.ExecuteReader();
            string x = "";
            while (r.Read())
            {
                x = r.GetString(0);
            }
            r.Close();
            return x;
        }
        public static string getusername(int id)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT username FROM users WHERE id='" + id + " limit 1'", db.con);
            MySqlDataReader r = cmd.ExecuteReader();
            string x = "";
            while (r.Read())
            {
                x = r.GetString(0);
            }
            r.Close();
            return x;
        }
        public static void setnume(int id, string nume)
        {
            MySqlCommand cmd = new MySqlCommand("UPDATE users SET nume ='" + nume + "' WHERE id='" + id + "'", db.con);
            cmd.ExecuteNonQuery();
        }
        public static void setprenume(int id, string prenume)
        {
            MySqlCommand cmd = new MySqlCommand("UPDATE users SET prenume ='" + prenume + "' WHERE id='" + id + "'", db.con);
            cmd.ExecuteNonQuery();
        }
        public static void setpass(int id, string pass)
        {
            MySqlCommand cmd = new MySqlCommand("UPDATE users SET pass ='" + pass + "' WHERE id='" + id + "'", db.con);
            cmd.ExecuteNonQuery();
        }
        public static int getid(string username)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT id FROM users WHERE username='" + username + "'", db.con);
            int r = Convert.ToInt32(cmd.ExecuteScalar());
            return r;
        }
        public static void settext(Form x, string text, int color, Label a, int d)
        {
            int poz = x.Width / 2 + d;
            poz -= f.masurare_string(text, a.Font) / 2;
            a.Location = new Point(poz, a.Location.Y);
            a.Text = text;
            if (color == 0)
                a.ForeColor = Color.Red;
            else if (color == 1)
                a.ForeColor = Color.Pink;
            else if (color == 2)
                a.ForeColor = Color.LightYellow;
            else
                a.ForeColor = Color.Gray;
        }
        public static void creare_cerere(string user1, string user2)
        {
            MySqlCommand cmd = new MySqlCommand("Insert into requests (username1,username2) values('" + user1 + "','" + user2 + "')", db.con);
            cmd.ExecuteNonQuery();
        }
        public static bool exista_cererea(string user1, string user2)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM requests WHERE username1 = '" + user1 + "' and username2 = '" + user2 + "'", db.con);
            int n = Convert.ToInt32(cmd.ExecuteScalar());
            if (n == 0)
                return false;
            return true;
        }
        public static bool exista_prietenie(string user1, string user2)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM prieteni WHERE username1 = '" + user1 + "' and username2 = '" + user2 + "'", db.con);
            int n = Convert.ToInt32(cmd.ExecuteScalar());
            if (n == 0)
                return false;
            return true;
        }
        public static bool are_prieteni(string user)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM prieteni WHERE username1 = '" + user + "'", db.con);
            int n = Convert.ToInt32(cmd.ExecuteScalar());
            if (n == 0)
                return false;
            return true;
        }
        public static int numar_prieteni(string user)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM prieteni WHERE username1 = '" + user + "'", db.con);
            return Convert.ToInt32(cmd.ExecuteScalar());
        }
        public static bool exista_cereri_active(string user)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM requests WHERE username2 = '" + user + "'", db.con);
            int n = Convert.ToInt32(cmd.ExecuteScalar());
            if (n == 0)
                return false;
            return true;
        }
        public static int nr_cereri_active(string user)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM requests WHERE username2 = '" + user + "'", db.con);
            return Convert.ToInt32(cmd.ExecuteScalar());
        }
        public static int masurare_string(string s, Font f)
        {
            return Convert.ToInt32(TextRenderer.MeasureText(s, f).Width);
        }


    }
}
