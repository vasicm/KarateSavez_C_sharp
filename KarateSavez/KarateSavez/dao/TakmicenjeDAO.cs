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
    class TakmicenjeDAO
    {
        private static string SQL_TAKMICENJA = "select * from takmicenje ";

        private static string SQL_NAZIVI_TAKMICENJA = "select distinct(takmicenje.NazivTakmicenja) as ret "
            + "from takmicenje";

        private static string SQL_DATUMI_TAKMICENJA = "select takmicenje.DatumPocetka as ret"
            + " from takmicenje"
            + " where takmicenje.NazivTakmicenja = \"Првенство РС\"";

        private static string SQL_NAZIVI_KATEGORIJA_NA_TAKMICENJU = "select concat(kategorija.Uzrast,\" \", kategorija.NazivKategorije) as ret"
            + " from takmicenje, takmicenje_kategorija, kategorija"
            + " where takmicenje_kategorija.IDTakmicenja = takmicenje.IDTakmicenja"
            + " and takmicenje_kategorija.IDKategorije = kategorija.IDKategorije"
            + " and takmicenje.DatumPocetka = \"20150111\""
            + " and takmicenje.NazivTakmicenja = \"Првенство РС\"";

        public static ArrayList naziviSvi()
        {
            return listaStringova(SQL_NAZIVI_TAKMICENJA);
        }

        public static ArrayList datumiSvi(string nazivTakmicenja)
        {
            string sqlTekstUpit = "select takmicenje.DatumPocetka as ret"
            + " from takmicenje"
            + " where takmicenje.NazivTakmicenja = \""+nazivTakmicenja+"\"";
            return listaStringova(sqlTekstUpit);
        }

        public static ArrayList naziviKAtegorija(string nazivTakmicenja, string datumTakmicenja)
        {
            string sqlTekstUpit = "select concat(kategorija.Uzrast,\" \", kategorija.NazivKategorije) as ret"
            + " from takmicenje, takmicenje_kategorija, kategorija"
            + " where takmicenje_kategorija.IDTakmicenja = takmicenje.IDTakmicenja"
            + " and takmicenje_kategorija.IDKategorije = kategorija.IDKategorije"
            + " and takmicenje.DatumPocetka = \""+datumTakmicenja+"\""
            + " and takmicenje.NazivTakmicenja = \""+nazivTakmicenja+"\"";
            return listaStringova(sqlTekstUpit);
        }

        public static ArrayList listaStringova(string sqlTekstUpit)
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
                    rezultat.Add(reader["ret"].ToString());
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

        public static ArrayList takmicenja(string sqlTekstUpit)
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
                    Takmicenje f = new Takmicenje();
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
