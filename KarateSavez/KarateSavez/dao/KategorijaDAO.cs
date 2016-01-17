using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Collections;

namespace KarateSavez.dao
{
    class KategorijaDAO
    {
        public static int idKategorije(string kategorija)
        {
            MySqlConnection konekcija = null;
            int rezultat = 0;

            try
            {
                konekcija = Konekcija.kreirajKonekciju();
                MySqlCommand upit = konekcija.CreateCommand();
                upit.CommandText = "select kategorija.IDKategorije"
                    + " from kategorija"
                    + " where kategorija.Uzrast = '" + kategorija.Split(' ')[0] + "'"
                    + " and kategorija.NazivKategorije = '" + kategorija.Split(' ')[1] + "'";
                MySqlDataReader reader = upit.ExecuteReader();
                reader.Read();
                rezultat = Convert.ToInt32(reader["IDKategorije"].ToString());
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Konekcija.zatvoriKonekciju(konekcija);
            }

            return rezultat;
        }
        public static ArrayList naziviKAtegorija(string nazivTakmicenja, string datumTakmicenja)
        {
            string sqlTekstUpit = "select concat(kategorija.Uzrast,\" \", kategorija.NazivKategorije) as rezultat"
                + " from takmicenje, takmicenje_kategorija, kategorija"
                + " where takmicenje_kategorija.IDTakmicenja = takmicenje.IDTakmicenja"
                + " and takmicenje_kategorija.IDKategorije = kategorija.IDKategorije"
                + " and takmicenje.DatumPocetka = \"" + datumTakmicenja + "\""
                + " and takmicenje.NazivTakmicenja = \"" + nazivTakmicenja + "\"";
            return listaStringova(sqlTekstUpit);
        }
        public static ArrayList listaStringova(string sqlTekstUpit)
        {
            MySqlConnection konekcija = null;
            ArrayList rezultat = new ArrayList();

            try
            {
                konekcija = Konekcija.kreirajKonekciju();
                MySqlCommand upit = konekcija.CreateCommand();
                upit.CommandText = sqlTekstUpit;
                MySqlDataReader reader = upit.ExecuteReader();
                while (reader.Read())
                {
                    rezultat.Add(reader["rezultat"].ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Konekcija.zatvoriKonekciju(konekcija);
            }

            return rezultat;
        }
    }
}
