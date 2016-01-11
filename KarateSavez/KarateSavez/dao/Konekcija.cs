using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace KarateSavez.dao
{
    class Konekcija
    {
        public static MySqlConnection kreirajKonekciju()
        {
            MySqlConnection konekcija = new MySqlConnection("Server=127.0.0.1;Port=3306;Database=karate_savez;Uid=root;Pwd=1234;");
            konekcija.Open();
            return konekcija;
        }

        public static void zatvoriKonekciju(MySqlConnection konekcija)
        {
            if (konekcija != null)
            {
                konekcija.Close();
            }
        }
    }
}
