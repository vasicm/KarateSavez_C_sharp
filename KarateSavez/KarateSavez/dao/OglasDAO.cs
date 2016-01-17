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
    class OglasDAO
    {
        private static string SQL_OGLASI = "select * from oglas";
        public static ArrayList oglasiSvi()
        {
            MySqlConnection konekcija = null;
            ArrayList rezultat = new ArrayList();
            try { 
                konekcija = Konekcija.kreirajKonekciju();
                MySqlCommand upit = konekcija.CreateCommand();
                upit.CommandText = SQL_OGLASI;
                MySqlDataReader reader = upit.ExecuteReader();
                while (reader.Read())
                {
                    Oglas f = new Oglas();
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

        public static bool dodaj(Oglas oglas)
        {
            MySqlConnection konekcija = null;
            try
            { 
                konekcija = Konekcija.kreirajKonekciju();
                MySqlCommand upit = konekcija.CreateCommand();
                upit.CommandText = "INSERT INTO `karate_savez`.`oglas` (`NaslovOglasa`, `TekstOglasa`, `DatumOglasa`, `TipOglasa`)"
                    + " VALUES('"
                    + oglas.NaslovOglasa + "', '"
                    + oglas.TekstOglasa + "', '"
                    + oglas.DatumOglasa.ToString("yyyy-MM-dd")+ "', '"
                    + oglas.TipOglasa + "')";

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

        public static bool azuriraj(Oglas oglas)
        {
            MySqlConnection konekcija = null;
            try
            {
                konekcija = Konekcija.kreirajKonekciju();
                MySqlCommand upit = konekcija.CreateCommand();

                upit.CommandText = "UPDATE `karate_savez`.`oglas`"
                    + " SET `NaslovOglasa`= '" + oglas.NaslovOglasa + "'"
                    + " , `TekstOglasa`= '" + oglas.TekstOglasa + "'"
                    + " , `DatumOglasa`= '" + oglas.DatumOglasa.ToString("yyyy-MM-dd") + "'"
                    + " , `TipOglasa`= '" + oglas.TipOglasa + "'"
                    + " WHERE `IdOglasa`= '" + oglas.IdOglasa + "'";

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

        public static bool brisi(Oglas oglas)
        {
            return brisi(oglas.IdOglasa);
        }

        public static bool brisi(int idOglasa)
        {
            MySqlConnection konekcija = null;
            try
            {
                konekcija = Konekcija.kreirajKonekciju();
                MySqlCommand upit = konekcija.CreateCommand();

                upit.CommandText = "DELETE FROM `karate_savez`.`oglas`"
                    + " WHERE `IdOglasa`= '" + idOglasa + "'";

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

    }
}
