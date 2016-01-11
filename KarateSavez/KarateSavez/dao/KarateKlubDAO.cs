using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using KarateSavez.dto;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace KarateSavez.dao
{
    class KarateKlubDAO
    {
        private static string SQL_SVI_KLUBOVI = "select karate_klub.*, karate_savez.NazivSaveza"
            +" from karate_klub , karate_savez"
            +" where karate_klub.IDSaveza = karate_savez.IDSaveza";

        private static string SQL_NAZIVI_KLUBOVA = "select concat(karate_klub.NazivKarateKluba , \" \", karate_klub.Sjediste) as nazivKarateKluba from karate_klub";

        public static ArrayList kluboviSvi()
        {
            return klubovi(SQL_SVI_KLUBOVI);
        }

        public static int idKluba(string nazivKluba)
        {
            int rezultat = 0;
            MySqlConnection konekcija = null;

            try { 
                string sqlTekstUpit = "select karate_klub.IDKluba"
                    + " from karate_klub"
                    + " where karate_klub.NazivKarateKluba = '" + nazivKluba.Split(' ')[0] + "'";

                konekcija = Konekcija.kreirajKonekciju();
                MySqlCommand upit = konekcija.CreateCommand();
                upit.CommandText = sqlTekstUpit;
                MySqlDataReader reader = upit.ExecuteReader();
                reader.Read();
                rezultat = Convert.ToInt32(reader["idkluba"].ToString());
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

        public static ArrayList naziviKlubova()
        {
            MySqlConnection konekcija = null;
            ArrayList rezultat = new ArrayList();

            try { 
                konekcija = Konekcija.kreirajKonekciju();
                MySqlCommand upit = konekcija.CreateCommand();
                upit.CommandText = SQL_NAZIVI_KLUBOVA;
                MySqlDataReader reader = upit.ExecuteReader();
                while (reader.Read())
                {
                    rezultat.Add(reader["NazivKarateKluba"].ToString());
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

        public static ArrayList klubovi(string sqlTekstUpit)
        {
            MySqlConnection konekcija = null;
            ArrayList rezultat = new ArrayList();

            try { 
                konekcija = Konekcija.kreirajKonekciju();
                MySqlCommand upit = konekcija.CreateCommand();
                upit.CommandText = sqlTekstUpit;
                MySqlDataReader reader = upit.ExecuteReader();
                while (reader.Read())
                {
                    KarateKlub f = new KarateKlub();
                    f.popuniObjekat(reader);
                    rezultat.Add(f);
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
