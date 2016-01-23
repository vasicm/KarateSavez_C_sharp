using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KarateSavez.dto;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace KarateSavez.dao
{
    class PrijavaDAO
    {
        public static bool prijavi(long jmb, string nazivTakmicenja, string datumTakmicenja, string kategorija)
        {
            MySqlConnection konekcija = null;
            int idKategorije = KategorijaDAO.idKategorije(kategorija);
            int idTakmicenja = TakmicenjeDAO.idTakmicenja(nazivTakmicenja, datumTakmicenja);

            try
            {
                konekcija = Konekcija.kreirajKonekciju();

                MySqlCommand komanda1 = konekcija.CreateCommand();
                komanda1.CommandText = "INSERT INTO `karate_savez`.`ucesce_pojedinca` (`IDTakmicenja`, `JMB`)"
                    + " VALUES ('" + idTakmicenja + "', '" + jmb + "')";
                komanda1.ExecuteNonQuery();

                MySqlCommand komanda2 = konekcija.CreateCommand();
                komanda2.CommandText = "INSERT INTO `karate_savez`.`prijavljuje_takmicenje_u_borbama` (`IDTakmicenja`, `IDKategorije`, `JMB`)"
                    + " VALUES ('" + idTakmicenja + "', '" + idKategorije + "', '" + jmb + "')";
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
        public static bool odjavi(long jmb, string nazivTakmicenja, string datumTakmicenja, string kategorija)
        {
            MySqlConnection konekcija = null;
            int idKategorije = KategorijaDAO.idKategorije(kategorija);
            int idTakmicenja = TakmicenjeDAO.idTakmicenja(nazivTakmicenja, datumTakmicenja);

            try
            {
                konekcija = Konekcija.kreirajKonekciju();

                MySqlCommand komanda1 = konekcija.CreateCommand();
                komanda1.CommandText = "DELETE FROM `karate_savez`.`prijavljuje_takmicenje_u_borbama`"
                    + " WHERE `IDTakmicenja`='" + idTakmicenja + "' and`IDKategorije`='" + idKategorije + "' and`JMB`='" + jmb + "';";
                komanda1.ExecuteNonQuery();

                MySqlCommand komanda2 = konekcija.CreateCommand();
                komanda2.CommandText = "DELETE FROM `karate_savez`.`ucesce_pojedinca`"
                    + " WHERE `IDTakmicenja`='" + idTakmicenja + "' and`JMB`='" + jmb + "';";
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
    }
}
