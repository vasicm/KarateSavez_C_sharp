using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using KarateSavez.dto;
using MySql.Data.MySqlClient;

namespace KarateSavez.dao
{
    class OglasDAO
    {
        private static string SQL_OGLASI = "TODO";
        public static ArrayList oglasiSvi()
        {
            MySqlConnection konekcija = Konekcija.kreirajKonekciju();
            MySqlCommand upit = konekcija.CreateCommand();
            upit.CommandText = SQL_OGLASI;
            MySqlDataReader reader = upit.ExecuteReader();
            ArrayList rezultat = new ArrayList();
            while (reader.Read())
            {
                Oglas f = new Oglas();
                f.popuniObjekat(reader);
                rezultat.Add(f);
            }
            reader.Close();
            Konekcija.zatvoriKonekciju(konekcija);
            return rezultat;
        }
    }
}
