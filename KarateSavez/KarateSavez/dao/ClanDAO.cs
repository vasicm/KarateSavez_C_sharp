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
    class ClanDAO
    {
        private static string SQL_SVI_CLANOVI = "select clan.*, karate_klub.nazivKarateKluba, karate_klub.sjediste "
                                           + " from clan, karate_klub"
                                           + " where clan.IDKluba = karate_klub.IDKluba ";

        public static bool dodaj(Clan clan)
        {
            int klubId = KarateKlubDAO.idKluba(clan.Klub);
            MySqlConnection konekcija = null;
            try
            {
                konekcija = Konekcija.kreirajKonekciju();
                MySqlCommand upit = konekcija.CreateCommand();
                upit.CommandText = "INSERT INTO `karate_savez`.`clan` (`JMB`, `DatumRodjenja`, `Pojas`, `IDKluba`, `Ime`, `Prezime`)"
                    + " VALUES('"
                    +clan.Jmb+"', '"
                    +clan.GodinaRodjenja.ToString("yyyy-MM-dd") +"', '"
                    +clan.Pojas+"', '"
                    +klubId+"', '"
                    +clan.Ime+"', '"
                    +clan.Prezime+"')";

                upit.ExecuteNonQuery();
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

        public static bool azuriraj(Clan clan)
        {
            int klubId = KarateKlubDAO.idKluba(clan.Klub);
            MySqlConnection konekcija = null;
            try
            {
                konekcija = Konekcija.kreirajKonekciju();
                MySqlCommand upit = konekcija.CreateCommand();

                upit.CommandText = "UPDATE `karate_savez`.`clan`"
                    + " SET `DatumRodjenja`= '" + clan.GodinaRodjenja.ToString("yyyy-MM-dd") + "'"
                    + " , `Pojas`= '" + clan.Pojas + "'"
                    + " , `IDKluba`= '" + klubId + "'"
                    + " , `Ime`= '" + clan.Ime + "'"
                    + " , `Prezime`= '" + clan.Prezime + "'"
                    + " WHERE `JMB`= '"+clan.Jmb+"'";

                upit.ExecuteNonQuery();
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

        public static ArrayList clanovi(string nazivKluba, string nazivTakmicenja, string datumTakmicenja, string kategorija)
        {
            string[] nazivSjediste = kategorija.Split(' ');
            string sqlTekstUpit = "select clan.*, karate_klub.nazivKarateKluba, karate_klub.sjediste"
                + " from prijavljuje_takmicenje_u_borbama, clan, karate_klub"
                + " where clan.IDKluba = karate_klub.IDKluba"
                + " and prijavljuje_takmicenje_u_borbama.JMB = clan.JMB"
                + " and prijavljuje_takmicenje_u_borbama.IDTakmicenja in (select takmicenje.IDTakmicenja"
                + " from takmicenje"
                + " where takmicenje.DatumPocetka = \""+datumTakmicenja+"\""
                + " and takmicenje.NazivTakmicenja = \""+nazivTakmicenja+"\")"
                + " and prijavljuje_takmicenje_u_borbama.IDKategorije in "
                + " (select kategorija.IDKategorije"
                + " from kategorija"
                + " where kategorija.NazivKategorije = \""+ nazivSjediste[1] + "\""
                + " and kategorija.Uzrast = \""+ nazivSjediste[0]+ "\")";

            if (nazivKluba != null) {
                sqlTekstUpit += " and karate_klub.nazivKarateKluba = \"" + nazivKluba.Split(' ')[0] + "\" ";
            }
            return listaClanova(sqlTekstUpit);
        }

        public static ArrayList clanoviSvi()
        {
            //MessageBox.Show("Morate upisati poruku", "Neispravan unos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return listaClanova(SQL_SVI_CLANOVI);
        }

        public static ArrayList clanoviImePrezime(string patern)
        {
            patern += ' ';
            patern = patern.Replace(' ', '%');

            string sqlTekstUpit = "select clan.*, karate_klub.nazivKarateKluba, karate_klub.sjediste"
                + " from clan, karate_klub"
                + " where clan.IDKluba = karate_klub.IDKluba"
                + " and (concat(clan.Ime, ' ', clan.Prezime) like '"+patern+"'"
                + " or concat(clan.Prezime, ' ', clan.Ime) like '"+patern+"')";

            return listaClanova(sqlTekstUpit);
        }

        public static ArrayList imena()
        {
            string sqlTekstUpit = "select distinct(concat(clan.Ime, ' ', clan.Prezime)) as ret"
                + " from clan"
                + " union"
                + " select distinct(concat(clan.Prezime, ' ', clan.Ime)) as ret"
                + " from clan";

            return listaStringova(sqlTekstUpit);
        }

        public static ArrayList clanoviKluba(string nazivKluba)
        {
            if (nazivKluba == null)
            {
                return listaClanova(SQL_SVI_CLANOVI);
            }
            else {
                string SQL_UPIT = SQL_SVI_CLANOVI + " and karate_klub.nazivKarateKluba = \"" + nazivKluba.Split(' ')[0] + "\" ";
                return listaClanova(SQL_UPIT);
            }
        }

        public static long jmbTakmicara(string ime, string prezime)
        {
            string sqlTekstUpit = "select clan.jmb from clan where clan.ime like '" + ime + "' and clan.prezime like '" + prezime + "'";
            long rezultat = 0;
            MySqlConnection konekcija = null;
            try
            {
                konekcija = Konekcija.kreirajKonekciju();
                MySqlCommand upit = konekcija.CreateCommand();
                upit.CommandText = sqlTekstUpit;
                MySqlDataReader reader = upit.ExecuteReader();

                reader.Read();
                rezultat = Convert.ToInt64(reader["jmb"].ToString());
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

        public static bool sadrzi(long jmb)
        {
            string sqlTekstUpit = "select count(clan.jmb) as broj from clan where clan.jmb = " + jmb;
            bool rezultat = false;
            MySqlConnection konekcija = null;
            try { 
                konekcija = Konekcija.kreirajKonekciju();
                MySqlCommand upit = konekcija.CreateCommand();
                upit.CommandText = sqlTekstUpit;
                MySqlDataReader reader = upit.ExecuteReader();

                reader.Read();
                if (Convert.ToInt32(reader["broj"].ToString()) == 0)
                {
                    rezultat = false;
                }
                else
                {
                    rezultat = true;
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

        private static ArrayList listaStringova(string sqlTekstUpit)
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
                    rezultat.Add(reader["ret"].ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                Konekcija.zatvoriKonekciju(konekcija);
            }
            return rezultat;
        }

        private static ArrayList listaClanova(string sqlTekstUpit)
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
                    Clan f = new Clan();
                    f.popuniObjekat(reader);
                    rezultat.Add(f);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                Konekcija.zatvoriKonekciju(konekcija);
            }
            return rezultat;
        }
    }
}
