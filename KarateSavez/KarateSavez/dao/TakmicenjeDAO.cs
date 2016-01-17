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
        private static string SQL_TAKMICENJA = "select takmicenje.*, concat(karate_klub.NazivKarateKluba, ' ',karate_klub.Adresa) as organizator"
            + " from takmicenje, karate_klub"
            + " where karate_klub.IDKluba = takmicenje.IDKluba";

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

        public static bool dodaj(Takmicenje takmicenje)
        {
            MySqlConnection konekcija = null;
            int klubId = KarateKlubDAO.idKluba(takmicenje.Organizator);

            try
            {
                konekcija = Konekcija.kreirajKonekciju();
                MySqlCommand komanda = konekcija.CreateCommand();
                komanda.CommandText = "INSERT INTO `karate_savez`.`takmicenje` (`NazivTakmicenja`, `DatumPocetka`, `IDKluba`, `Adresa`) "
                    + " VALUES ('"
                    + takmicenje.Naziv +"', '"
                    + takmicenje.Datum.ToString("yyyy-MM-dd") + "', '"
                    + klubId+"', '"
                    + takmicenje.Adresa+"')";
                komanda.ExecuteNonQuery();

                int idTakmicenja = TakmicenjeDAO.idTakmicenja(takmicenje.Naziv, takmicenje.Datum.ToString("yyyy-MM-dd"));
                MySqlCommand komanda2 = konekcija.CreateCommand();
                komanda2.CommandText = "INSERT INTO `karate_savez`.`takmicenje_kategorija` (`IDTakmicenja`, `IDKategorije`)"
                    + " select "+idTakmicenja+", borbe_pojedinacno.IDKategorije"
                    + " from borbe_pojedinacno";
                komanda2.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                Konekcija.zatvoriKonekciju(konekcija);
            }

            return true;
        }
 
        public static bool azuriraj(Takmicenje takmicenje)
        {
            MySqlConnection konekcija = null;
            int klubId = KarateKlubDAO.idKluba(takmicenje.Organizator);

            try
            {
                konekcija = Konekcija.kreirajKonekciju();
                MySqlCommand komanda = konekcija.CreateCommand();

                komanda.CommandText = "UPDATE `karate_savez`.`takmicenje` "
                    +" SET `NazivTakmicenja`='"+takmicenje.Naziv+"',"
                    +" `DatumPocetka`='"+takmicenje.Datum.ToString("yyyy-MM-dd")+"',"
                    +" `IDKluba`='"+klubId+"',"
                    +" `Adresa`='"+takmicenje.Adresa+"'"
                    +" WHERE `IDTakmicenja`='"+takmicenje.Id+"'";

                komanda.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                Konekcija.zatvoriKonekciju(konekcija);
            }
            return true;
        }

        public static bool brisi(Takmicenje takmicenje)
        {
            return brisi(takmicenje.Id);
        }

        public static bool brisi(int idTakmicenja)
        {
            MySqlConnection konekcija = null;
            try
            {
                konekcija = Konekcija.kreirajKonekciju();

                MySqlCommand komanda = konekcija.CreateCommand();
                komanda.CommandText = "DELETE FROM `karate_savez`.`takmicenje_kategorija`"
                    + " WHERE `IDTakmicenja`='" + idTakmicenja + "'";
                komanda.ExecuteNonQuery();

                MySqlCommand komanda2 = konekcija.CreateCommand();
                komanda2.CommandText = "DELETE FROM `karate_savez`.`takmicenje`"
                    + " WHERE `IDTakmicenja`='"+idTakmicenja+"'";
                komanda2.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                Konekcija.zatvoriKonekciju(konekcija);
            }
            return true;
        }

        public static ArrayList takmicenjaSva()
        {
            return takmicenja(SQL_TAKMICENJA);
        }

        public static ArrayList takmicenjaPretraga(string naziv)
        {
            string uslov = " and takmicenje.NazivTakmicenja like '%"+naziv+"%'";
            return takmicenja(SQL_TAKMICENJA + uslov);
        }

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

        public static int idTakmicenja(string nazivTakmicenja, string datumTakmicenja)
        {
            MySqlConnection konekcija = null;
            int rezultat = 0;

            try
            {
                konekcija = Konekcija.kreirajKonekciju();
                MySqlCommand upit = konekcija.CreateCommand();
                upit.CommandText = "select takmicenje.IDTakmicenja"
                    + " from takmicenje"
                    + " where takmicenje.DatumPocetka = '" + datumTakmicenja + "'"
                    + " and takmicenje.NazivTakmicenja = '" + nazivTakmicenja + "'";

                MySqlDataReader reader = upit.ExecuteReader();
                reader.Read();
                rezultat = Convert.ToInt32(reader["IDTakmicenja"].ToString());
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
