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
    class BorbaDAO
    {
        private static string SQL_BORBE = "select * from borba ";
        public static ArrayList borbeSve(string nazivTakmicenja, string datumTakmicenja, string kategorija)
        {
            string borbeUpitString = "select borba.PoeniPlavi, borba.PoeniCrveni, borba.KaznePlavi, borba.KazneCrveni, borba.nivoTakmicenja as krug, concat(c1.Ime, ' ', c1.Prezime) as plavi,  concat(c2.Ime, ' ', c2.Prezime) as crveni," 
                + " concat(kategorija.Uzrast, ' ', kategorija.NazivKategorije) as kategorija, takmicenje.NazivTakmicenja, takmicenje.DatumPocetka as datumTakmicenja"
                + " from borba, clan c1, clan c2, takmicenje, kategorija"
                + " where borba.JMBPlavi = c1.JMB and borba.JMBCrveni = c2.JMB"
                + " and takmicenje.IDTakmicenja = borba.IDTakmicenja and kategorija.IDKategorije = borba.IDKategorije";

            int idTakmicenja = TakmicenjeDAO.idTakmicenja(nazivTakmicenja, datumTakmicenja);
            int idKategorije = KategorijaDAO.idKategorije(kategorija);

            borbeUpitString += " and borba.IDTakmicenja = "+idTakmicenja+" and borba.IDKategorije = "+idKategorije+"";

            MySqlConnection konekcija = Konekcija.kreirajKonekciju();
            MySqlCommand upit = konekcija.CreateCommand();
            upit.CommandText = borbeUpitString;
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

        public static bool dodaj(Borba borba)
        {
            MySqlConnection konekcija = null;

            int idTakmicenja = TakmicenjeDAO.idTakmicenja(borba.NazivTakmicenja, borba.DatumTakmicenja.ToString("yyyy-MM-dd"));
            int idKategorije = KategorijaDAO.idKategorije(borba.Kategorija);

            long jmbPlavi = ClanDAO.jmbTakmicara(borba.Plavi.Split(' ')[0], borba.Plavi.Split(' ')[1]);
            long jmbCrveni = ClanDAO.jmbTakmicara(borba.Crveni.Split(' ')[0], borba.Crveni.Split(' ')[1]);

            try
            {
                konekcija = Konekcija.kreirajKonekciju();
                MySqlCommand komanda = konekcija.CreateCommand();
                komanda.CommandText = "INSERT INTO `karate_savez`.`borba` (`IDTakmicenja`, `IDKategorije`, `JMBPlavi`, `JMBCrveni`, `PoeniPlavi`, `PoeniCrveni`, `KaznePlavi`, `KazneCrveni`, `nivoTakmicenja`)"
                    + "VALUES ('"+idTakmicenja+"', '"+idKategorije+"', '"+jmbPlavi+"', '"+jmbCrveni+"', '"+borba.PoeniPlavi+"', '"+borba.PoeniCrveni+"', '"+borba.KaznePlavi+"', '"+borba.KazneCrveni+"', '"+borba.Krug+"')";

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

        public static bool azuriraj(Borba borba)
        {
            MySqlConnection konekcija = null;

            int idTakmicenja = TakmicenjeDAO.idTakmicenja(borba.NazivTakmicenja, borba.DatumTakmicenja.ToString("yyyy-MM-dd"));
            int idKategorije = KategorijaDAO.idKategorije(borba.Kategorija);

            long jmbPlavi = ClanDAO.jmbTakmicara(borba.Plavi.Split(' ')[0], borba.Plavi.Split(' ')[1]);
            long jmbCrveni = ClanDAO.jmbTakmicara(borba.Crveni.Split(' ')[0], borba.Crveni.Split(' ')[1]);

            try
            {
                konekcija = Konekcija.kreirajKonekciju();
                MySqlCommand komanda = konekcija.CreateCommand();

                komanda.CommandText = "UPDATE `karate_savez`.`borba`"
                    + " SET `JMBPlavi`='"+jmbPlavi+"',"
                    + " `JMBCrveni`='"+jmbCrveni+"',"
                    + " `PoeniPlavi`='"+borba.PoeniPlavi+"',"
                    + " `PoeniCrveni`='"+borba.PoeniCrveni+"',"
                    + " `KaznePlavi`='"+borba.KaznePlavi+"',"
                    + " `KazneCrveni`='"+borba.KazneCrveni+"',"
                    + " `nivoTakmicenja`='"+borba.Krug+"'"
                    + " WHERE `IDKategorije`='"+idKategorije+"' and `IDTakmicenja`='"+idTakmicenja+"' and `JMBPlavi`='"+jmbPlavi+"' and `JMBCrveni`='"+jmbCrveni+"'";

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

        public static bool brisi(Borba borba)
        {
            MySqlConnection konekcija = null;

            int idTakmicenja = TakmicenjeDAO.idTakmicenja(borba.NazivTakmicenja, borba.DatumTakmicenja.ToString("yyyy-MM-dd"));
            int idKategorije = KategorijaDAO.idKategorije(borba.Kategorija);

            long jmbPlavi = ClanDAO.jmbTakmicara(borba.Plavi.Split(' ')[0], borba.Plavi.Split(' ')[1]);
            long jmbCrveni = ClanDAO.jmbTakmicara(borba.Crveni.Split(' ')[0], borba.Crveni.Split(' ')[1]);

            try
            {
                konekcija = Konekcija.kreirajKonekciju();
                MySqlCommand komanda = konekcija.CreateCommand();

                komanda.CommandText = "DELETE FROM `karate_savez`.`borba`"
                    + " WHERE `IDKategorije`='"+idKategorije+"' and `IDTakmicenja`='"+idTakmicenja+"'"
                    + " and `JMBPlavi`='"+jmbPlavi+"' and `JMBCrveni`='"+jmbCrveni+"'";

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
    }
}
