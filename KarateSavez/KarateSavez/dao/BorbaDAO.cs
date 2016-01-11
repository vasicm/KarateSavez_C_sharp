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
    class BorbaDAO
    {
        private static string SQL_BORBE = "TODO";
        public static ArrayList borbeSve()
        {
            MySqlConnection konekcija = Konekcija.kreirajKonekciju();
            MySqlCommand upit = konekcija.CreateCommand();
            upit.CommandText = SQL_BORBE;
            MySqlDataReader reader = upit.ExecuteReader();
            ArrayList rezultat = new ArrayList();
            while (reader.Read())
            {
                Borba f = new Borba();
                f.popuniObjekat(reader);
                rezultat.Add(f);
            }
            reader.Close();
            Konekcija.zatvoriKonekciju(konekcija);
            return rezultat;
        }
    }
}
