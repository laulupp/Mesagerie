using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace atestat
{
    static class db
    {
        public static MySqlConnection con;
        static string host = "sql11.freemysqlhosting.net";
        static string port = "3306";
        public static string dbname = "sql11489825";
        static string user = "sql11489825";
        static string pass = "KTGKBpSJNW";
        static string connectionString = "SERVER=" + host + ";" + "PORT=" + port + ";" + "DATABASE=" + dbname + ";" + "UID=" + user + ";" + "PASSWORD=" + pass + ";";
        public static MySqlConnection getConnection()
        {
            return new MySqlConnection(connectionString);
        }
        public static bool check_connection()
        {
            if (con.State == ConnectionState.Open)
            {
                Console.WriteLine("aa");
                create_users_table();
                create_prieteni_table();
                create_requests_table();
                create_mesaje_table();
                return true;
            }
            return false;
        }
        static void create_mesaje_table()
        {

            string cmd = "SELECT COUNT(*) FROM information_schema.tables WHERE table_schema = '" + dbname + "' AND table_name = 'mesaje'";
            MySqlCommand c = new MySqlCommand(cmd, con);
            int n = Convert.ToInt32(c.ExecuteScalar());
            if (n == 0)
            {
                //Console.WriteLine("aaa");
                cmd = "CREATE TABLE `" + dbname + "`.`mesaje` ( `id` INT(100) NOT NULL AUTO_INCREMENT , `username1` VARCHAR(255) NOT NULL , `username2` VARCHAR(255) NOT NULL ,  `mesaj` VARCHAR(255) NOT NULL , PRIMARY KEY (`id`)) ENGINE = InnoDB;";
                c = new MySqlCommand(cmd, con);
                c.ExecuteNonQuery();
            }
        }
        static void create_users_table()
        {

            string cmd = "SELECT COUNT(*) FROM information_schema.tables WHERE table_schema = '" + dbname + "' AND table_name = 'users'";
            MySqlCommand c = new MySqlCommand(cmd, con);
            int n = Convert.ToInt32(c.ExecuteScalar());
            if (n == 0)
            {
                //Console.WriteLine("aaa");
                cmd = "CREATE TABLE `" + dbname + "`.`users` ( `id` INT(100) NOT NULL AUTO_INCREMENT , `username` VARCHAR(255) NOT NULL , `pass` VARCHAR(255) NOT NULL , `nume` VARCHAR(255) NOT NULL , `prenume` VARCHAR(255) NOT NULL , PRIMARY KEY (`id`)) ENGINE = InnoDB;";
                c = new MySqlCommand(cmd, con);
                c.ExecuteNonQuery();
            }
        }
        static void create_prieteni_table()
        {

            string cmd = "SELECT COUNT(*) FROM information_schema.tables WHERE table_schema = '" + dbname + "' AND table_name = 'prieteni'";
            MySqlCommand c = new MySqlCommand(cmd, con);
            int n = Convert.ToInt32(c.ExecuteScalar());
            if (n == 0)
            {
                //Console.WriteLine("aaa");
                cmd = "CREATE TABLE `" + dbname + "`.`prieteni` ( `id` INT(100) NOT NULL AUTO_INCREMENT , `username1` VARCHAR(255) NOT NULL , `username2` VARCHAR(255) NOT NULL, PRIMARY KEY (`id`)) ENGINE = InnoDB;";
                c = new MySqlCommand(cmd, con);
                c.ExecuteNonQuery();
            }
        }
        static void create_requests_table()
        {
            string cmd = "SELECT COUNT(*) FROM information_schema.tables WHERE table_schema = '" + dbname + "' AND table_name = 'requests'";
            MySqlCommand c = new MySqlCommand(cmd, con);
            int n = Convert.ToInt32(c.ExecuteScalar());
            if (n == 0)
            {
                //Console.WriteLine("aaa");
                cmd = "CREATE TABLE `" + dbname + "`.`requests` ( `id` INT(100) NOT NULL AUTO_INCREMENT , `username1` VARCHAR(255) NOT NULL , `username2` VARCHAR(255) NOT NULL, PRIMARY KEY (`id`)) ENGINE = InnoDB;";
                c = new MySqlCommand(cmd, con);
                c.ExecuteNonQuery();
            }
        }
    }
}
