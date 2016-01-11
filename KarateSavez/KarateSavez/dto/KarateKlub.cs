using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace KarateSavez.dto
{
    class KarateKlub
    {
        private int idKluba;
        private string nazivKarateKluba;
        private string adresa;
        private string sjediste;
        private string opis;
        private string nazivSaveza;

        public void popuniObjekat(MySqlDataReader reader)
        {
            this.idKluba = Convert.ToInt32(reader["idKluba"].ToString());
            this.nazivKarateKluba = reader["nazivKarateKluba"].ToString();
            this.adresa = reader["adresa"].ToString();
            this.sjediste = reader["sjediste"].ToString();
            this.opis = reader["opis"].ToString();
            this.nazivSaveza = reader["nazivSaveza"].ToString();
        }

        public KarateKlub()
        {
        }

        public KarateKlub(int idKluba, string nazivKarateKluba, string adresa, string sjediste, string opis, string nazivSaveza)
        {
            this.idKluba = idKluba;
            this.nazivKarateKluba = nazivKarateKluba;
            this.adresa = adresa;
            this.sjediste = sjediste;
            this.opis = opis;
            this.nazivSaveza = nazivSaveza;
        }

        public int IdKluba
        {
            get
            {
                return idKluba;
            }

            set
            {
                idKluba = value;
            }
        }

        public string NazivKarateKluba
        {
            get
            {
                return nazivKarateKluba;
            }

            set
            {
                nazivKarateKluba = value;
            }
        }

        public string Adresa
        {
            get
            {
                return adresa;
            }

            set
            {
                adresa = value;
            }
        }

        public string Sjediste
        {
            get
            {
                return sjediste;
            }

            set
            {
                sjediste = value;
            }
        }

        public string Opis
        {
            get
            {
                return opis;
            }

            set
            {
                opis = value;
            }
        }

        public string NazivSaveza
        {
            get
            {
                return nazivSaveza;
            }

            set
            {
                nazivSaveza = value;
            }
        }
    }
}
